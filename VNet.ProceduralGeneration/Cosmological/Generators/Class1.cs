using System.Numerics;
using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;
using VNet.Scientific.NumericalVolumes;

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public class VSphere
    {
        public Vector3 Center { get; }
        public float Diameter { get; }
        public BoundingBox<float> OrientedBoundingBox { get; set; }
        public List<Vector3> Points { get; private set; }
        INoiseAlgorithm NoiseAlgorithm { get; set; }
        private IRandomGenerationAlgorithm RandomAlgorithm { get; set; }


        public VSphere(Vector3 center, float diameter)
        {
            Center = center;
            Diameter = diameter;
            OrientedBoundingBox = new BoundingBox<float>(center, diameter / 2, Vector3.One * diameter);
            Points = new List<Vector3>();
        }

        public void UpdateBoundingBox()
        {
            this.OrientedBoundingBox = new BoundingBox<float>(this.Center, this.Diameter / 2, Vector3.One * this.Diameter);
        }

        public void Warp(INoiseAlgorithm noiseAlgorithm, float warpAmount)
        {
            var radius = Diameter / 2.0f;
            var numberOfPoints = (int)(4.0 * Math.PI * Math.Pow(radius, 2));

            for (var i = 0; i < numberOfPoints; i++)
            {
                var u = RandomAlgorithm.NextSingle();
                var v = RandomAlgorithm.NextSingle();

                var theta = 2.0f * (float)Math.PI * u;
                var phi = (float)Math.Acos(2.0f * v - 1.0f);

                var pointOnSphere = new Vector3(
                    radius * (float)Math.Sin(phi) * (float)Math.Cos(theta),
                    radius * (float)Math.Sin(phi) * (float)Math.Sin(theta),
                    radius * (float)Math.Cos(phi)
                );

                var warpFactor = (float)noiseAlgorithm.GenerateSpatialSingleSample(new double[] { pointOnSphere.X, pointOnSphere.Y, pointOnSphere.Z });
                var warpedPoint = pointOnSphere + pointOnSphere * warpFactor * warpAmount;

                Points.Add(Center + warpedPoint);
            }
        }
    }

    public class RandomSphereGenerator
    {
        private Random _random = new Random();

        public float PercentageOfVolumeCoveredBySpheres { get; set; }
        public float MinSphereSize { get; set; }
        public float MaxSphereSize { get; set; }
        public float PercentageOfOverlappingSpheres { get; set; }
        public float MinOverlapAmount { get; set; }
        public float MaxOverlapAmount { get; set; }


        public List<VSphere> GenerateSpheres(float[,,] volume)
        {
            var volumeSize = volume.GetLength(0) * volume.GetLength(1) * volume.GetLength(2);
            var targetSphereVolume = volumeSize * PercentageOfVolumeCoveredBySpheres;
            var spheres = new List<VSphere>();

            while (targetSphereVolume > 0)
            {
                var diameter = (float)(_random.NextDouble() * (MaxSphereSize - MinSphereSize) + MinSphereSize);
                var sphereVolume = (float)(4.0 / 3.0 * Math.PI * Math.Pow(diameter / 2, 3));

                if (sphereVolume > targetSphereVolume)
                {
                    diameter = (float)Math.Pow(targetSphereVolume * 3.0 / (4.0 * Math.PI), 1.0 / 3.0) * 2;
                    sphereVolume = targetSphereVolume;
                }

                var center = new Vector3(
                    (float)(_random.NextDouble() * (volume.GetLength(0) - diameter)),
                    (float)(_random.NextDouble() * (volume.GetLength(1) - diameter)),
                    (float)(_random.NextDouble() * (volume.GetLength(2) - diameter))
                );

                var sphere = new VSphere(center, diameter);

                var acceptableOverlap = false;
                while (!acceptableOverlap)
                {
                    var overlapAmount = CalculateOverlapAmount(sphere, spheres);

                    if (overlapAmount < MinOverlapAmount || overlapAmount > MaxOverlapAmount)
                    {
                        sphere = new VSphere(new Vector3(
                            (float)(_random.NextDouble() * (volume.GetLength(0) - diameter)),
                            (float)(_random.NextDouble() * (volume.GetLength(1) - diameter)),
                            (float)(_random.NextDouble() * (volume.GetLength(2) - diameter))
                        ), diameter);
                    }
                    else
                    {
                        acceptableOverlap = true;
                    }
                }

                spheres.Add(sphere);
                targetSphereVolume -= sphereVolume;
            }

            return spheres;
        }

        private float CalculateOverlapAmount(VSphere sphere, List<VSphere> existingSpheres)
        {
            float overlapAmount = 0;

            foreach (var existingSphere in existingSpheres)
            {
                var distanceBetweenCenters = Vector3.Distance(sphere.Center, existingSphere.Center);
                var combinedRadii = (sphere.Diameter + existingSphere.Diameter) / 2;

                if (distanceBetweenCenters < combinedRadii)
                {
                    overlapAmount += combinedRadii - distanceBetweenCenters;
                }
            }

            return overlapAmount;
        }
    }

    public class SCircle
    {
        public Vector3 Center { get; }
        public float Diameter { get; }
        public float Thickness { get; }
        public Vector3 Normal { get; set; }  // Indicates the orientation of the circle. This should be a normalized vector.

        public BoundingBox<float> OrientedBoundingBox { get; set; }
        public List<Vector3> Points { get; private set; }
        INoiseAlgorithm NoiseAlgorithm { get; set; }
        private IRandomGenerationAlgorithm RandomAlgorithm { get; set; }


        public SCircle(Vector3 center, float diameter, float thickness)
        {
            Center = center;
            Diameter = diameter;
            Thickness = thickness;
            OrientedBoundingBox = new BoundingBox<float>(center, Diameter / 2, Vector3.One * Diameter);
            Points = new List<Vector3>();
        }

        public void UpdateBoundingBox()
        {
            // Determine the rotation axis and angle between current orientation and the Normal
            var currentOrientation = Vector3.Transform(new Vector3(0, 0, 1), this.OrientedBoundingBox.Rotation); // Extract current orientation from bounding box
            var rotationAxis = Vector3.Cross(currentOrientation, this.Normal);

            rotationAxis = rotationAxis.LengthSquared() < 1e-10 ? currentOrientation : // If the vectors are nearly parallel, just use the current orientation
                // Check for near co-linearity
                Vector3.Normalize(rotationAxis);

            var dot = Vector3.Dot(currentOrientation, this.Normal);
            var rotationAngle = (float)Math.Acos(Math.Clamp(dot, -1.0f, 1.0f));  // Ensure clamping due to precision errors

            var rotation = Quaternion.CreateFromAxisAngle(rotationAxis, rotationAngle);

            // Update the bounding box based on the circle's orientation and position
            var rotationMatrix = Matrix4x4.CreateFromQuaternion(rotation);
            this.OrientedBoundingBox = new BoundingBox<float>(this.Center, this.Diameter / 2, Vector3.Transform(new Vector3(this.Diameter, this.Diameter, this.Thickness), rotationMatrix));
        }


        public void Warp(INoiseAlgorithm noiseAlgorithm, float warpAmount)
        {
            var numberOfPoints = (int)(Math.PI * Math.Pow(Diameter, 2));

            for (var i = 0; i < numberOfPoints; i++)
            {
                var u = RandomAlgorithm.NextSingle() * 2 * (float)Math.PI;
                var r = (float)Math.Sqrt(RandomAlgorithm.NextSingle()) * Diameter / 2;

                var pointOnCircle = new Vector3(
                    Center.X + r * (float)Math.Cos(u),
                    Center.Y + r * (float)Math.Sin(u),
                    Center.Z
                );

                var warpFactorXY = (float)noiseAlgorithm.GenerateSpatialSingleSample(new double[] { pointOnCircle.X, pointOnCircle.Y });
                var warpedPoint = pointOnCircle + Vector3.Normalize(pointOnCircle - Center) * warpFactorXY * warpAmount;

                Points.Add(warpedPoint);
            }
        }
    }

    public class RandomCircleGenerator
    {
        private Random _random = new Random();

        public float MinThickness { get; set; }
        public float MaxThickness { get; set; }

        public List<SCircle> GenerateCirclesFromIntersections(List<VSphere> spheres)
        {
            var circles = new List<SCircle>();

            for (var i = 0; i < spheres.Count; i++)
            {
                for (var j = i + 1; j < spheres.Count; j++)
                {
                    var sphere1 = spheres[i];
                    var sphere2 = spheres[j];

                    var distance = Vector3.Distance(sphere1.Center, sphere2.Center);
                    var combinedRadii = (sphere1.Diameter + sphere2.Diameter) / 2;

                    // Check if spheres intersect
                    if (distance < combinedRadii)
                    {
                        // Calculate intersection circle center (approximation)
                        var direction = Vector3.Normalize(sphere2.Center - sphere1.Center);
                        var circleCenter = sphere1.Center + direction * (sphere1.Diameter / 2);

                        var circleDiameter = combinedRadii - distance; // Approximate diameter
                        var thickness = (float)(_random.NextDouble() * (MaxThickness - MinThickness) + MinThickness);

                        // Create the SCircle with the calculated orientation
                        var circle = new SCircle(circleCenter, circleDiameter, thickness)
                        {
                            // Set the circle's normal to the direction between the sphere centers
                            Normal = direction
                        };

                        // Update the circle's oriented bounding box to match this orientation
                        circle.UpdateBoundingBox();

                        circles.Add(circle);
                    }
                }
            }

            return circles;
        }
    }


    public class FCylinder
    {
        public Vector3 Center { get; set; }
        public float Diameter { get; }
        public float Length { get; set; }
        public Vector3 Direction
        {
            get
            {
                return Vector3.Transform(new Vector3(0, 0, 1), this.OrientedBoundingBox.Rotation);  // Default direction is Z-axis, transformed by the bounding box's rotation.
            }
            set
            {
                var currentDirection = Direction;
                var targetDirection = Vector3.Normalize(value);

                // Find rotation axis and angle
                var rotationAxis = Vector3.Cross(currentDirection, targetDirection);
                var dot = Vector3.Dot(currentDirection, targetDirection);
                var rotationAngle = (float)Math.Acos(dot);  // Angle between current and target direction

                var rotation = Quaternion.CreateFromAxisAngle(rotationAxis, rotationAngle);

                this.OrientedBoundingBox.Rotation = Matrix4x4.CreateFromQuaternion(rotation) * this.OrientedBoundingBox.Rotation;

                UpdateBoundingBox();
            }
        }



        public BoundingBox<float> OrientedBoundingBox { get; set; }
        public List<Vector3> Points { get; private set; }
        INoiseAlgorithm NoiseAlgorithm { get; set; }
        private IRandomGenerationAlgorithm RandomAlgorithm { get; set; }

        public void UpdateBoundingBox()
        {
            var orientation = Vector3.Transform(new Vector3(0, 0, 1), this.OrientedBoundingBox.Rotation);  // Extract direction from the current rotation
            this.OrientedBoundingBox = new BoundingBox<float>(this.Center, this.Diameter / 2, orientation * this.Length);
        }

        public FCylinder(Vector3 center, float diameter, float length)
        {
            Center = center;
            Diameter = diameter;
            Length = length;
            OrientedBoundingBox = new BoundingBox<float>(center, Diameter / 2, new Vector3(Diameter, Diameter, Length));
            Points = new List<Vector3>();
        }

        public void Warp(INoiseAlgorithm noiseAlgorithm, float warpAmount)
        {
            var numberOfPoints = (int)(Math.PI * Diameter * Length);

            for (var i = 0; i < numberOfPoints; i++)
            {
                var h = RandomAlgorithm.NextSingle() * Length - Length / 2;
                var u = RandomAlgorithm.NextSingle() * 2 * (float)Math.PI;
                var r = Diameter / 2;

                var pointOnCylinder = new Vector3(
                    Center.X + r * (float)Math.Cos(u),
                    Center.Y + r * (float)Math.Sin(u),
                    Center.Z + h
                );

                var warpFactor = (float)NoiseAlgorithm.GenerateSpatialSingleSample(new double[] { pointOnCylinder.X, pointOnCylinder.Y });
                var warpedPoint = pointOnCylinder + Vector3.Normalize(pointOnCylinder - new Vector3(Center.X, Center.Y, pointOnCylinder.Z)) * warpFactor * warpAmount;

                Points.Add(warpedPoint);
            }
        }
    }

    public class RandomCylinderGenerator
    {
        private Random _random = new Random();

        public List<FCylinder> GenerateCylindersFromIntersections(List<SCircle> circles)
        {
            var cylinders = new List<FCylinder>();

            for (var i = 0; i < circles.Count; i++)
            {
                for (var j = i + 1; j < circles.Count; j++)
                {
                    var circle1 = circles[i];
                    var circle2 = circles[j];

                    var distance = Vector3.Distance(circle1.Center, circle2.Center);

                    // Check if circles intersect
                    if (distance < (circle1.Diameter / 2 + circle2.Diameter / 2))
                    {
                        // Calculate intersection cylinder properties (approximation)
                        var direction = Vector3.Normalize(circle2.Center - circle1.Center);
                        var cylinderLength = distance;
                        var cylinderDiameter = Math.Min(circle1.Diameter, circle2.Diameter);
                        var cylinderCenter = circle1.Center + direction * distance / 2;

                        cylinders.Add(new FCylinder(cylinderCenter, cylinderDiameter, cylinderLength));
                    }
                }
            }

            return cylinders;
        }
    }


    public class CylinderMerger
    {
        public float MaxCylinderMergeDistance { get; set; }
        public float MaxCylinderMergeAngle { get; set; }
        public int MaxCylinderMergeIterations { get; set; }

        public List<FCylinder> MergeCylinders(List<FCylinder> cylinders)
        {
            var anyMerged = true;
            var iterations = 0;

            while (anyMerged && iterations < MaxCylinderMergeIterations)
            {
                anyMerged = false;
                var newCylinders = new List<FCylinder>();

                for (var i = 0; i < cylinders.Count; i++)
                {
                    var merged = false;
                    for (var j = i + 1; j < cylinders.Count; j++)
                    {
                        if (!CanMerge(cylinders[i], cylinders[j])) continue;

                        newCylinders.Add(Merge(cylinders[i], cylinders[j]));
                        cylinders.RemoveAt(j);
                        merged = true;
                        anyMerged = true;
                        break;  // Exit inner loop since cylinder[i] is now merged
                    }

                    if (!merged)
                    {
                        newCylinders.Add(cylinders[i]);
                    }
                }

                cylinders = newCylinders;
                iterations++;
            }

            return cylinders;
        }

        private bool CanMerge(FCylinder cyl1, FCylinder cyl2)
        {
            var distance = Vector3.Distance(cyl1.Center, cyl2.Center);
            if (distance > MaxCylinderMergeDistance)
            {
                return false;
            }

            // Calculate angle between orientations (simple approach using dot product)
            var dir1 = Vector3.Normalize(cyl1.Center - (cyl1.Center - new Vector3(0, 0, cyl1.Length / 2)));
            var dir2 = Vector3.Normalize(cyl2.Center - (cyl2.Center - new Vector3(0, 0, cyl2.Length / 2)));
            var dot = Vector3.Dot(dir1, dir2);
            var angle = (float)Math.Acos(dot) * (180.0f / (float)Math.PI);

            return !(angle > MaxCylinderMergeAngle);
        }

        private FCylinder Merge(FCylinder cyl1, FCylinder cyl2)
        {
            var newCenter = (cyl1.Center + cyl2.Center) / 2;
            var newDiameter = (cyl1.Diameter + cyl2.Diameter) / 2;
            var newLength = Vector3.Distance(cyl1.Center, cyl2.Center) + (cyl1.Length + cyl2.Length) / 2;

            return new FCylinder(newCenter, newDiameter, newLength);
        }
    }

    public class LatticeAdjuster
    {
        public float MinLatticeMove { get; set; }
        public float MaxLatticeMove { get; set; }
        public float MinLatticeRotate { get; set; }
        public float MaxLatticeRotate { get; set; }
        public float MinLatticeLengthAdjust { get; set; }
        public float MaxLatticeLengthAdjust { get; set; }

        public List<FCylinder> AdjustToLattice(List<FCylinder> cylinders)
        {
            var adjusted = true;
            while (adjusted)
            {
                adjusted = false;
                for (var i = 0; i < cylinders.Count; i++)
                {
                    var cylinder = cylinders[i];
                    var closestNeighbor = FindClosestNeighbor(cylinder, cylinders);

                    // Calculate adjustments
                    float moveAmount, rotateAmount, lengthAdjustAmount;
                    var canAdjust = CalculateAdjustments(cylinder, closestNeighbor, out moveAmount, out rotateAmount, out lengthAdjustAmount);

                    if (canAdjust)
                    {
                        ApplyAdjustments(cylinder, moveAmount, rotateAmount, lengthAdjustAmount);
                        adjusted = true;
                    }
                    else
                    {
                        cylinders.RemoveAt(i);
                        i--; // adjust index due to removal
                    }
                }
            }

            return cylinders;
        }

        private FCylinder FindClosestNeighbor(FCylinder cylinder, List<FCylinder> cylinders)
        {
            var minDistance = float.MaxValue;
            FCylinder closest = null;
            foreach (var other in cylinders)
            {
                if (other == cylinder) continue; // skip self

                var distance = Vector3.Distance(cylinder.Center, other.Center);
                if (!(distance < minDistance)) continue;
                minDistance = distance;
                closest = other;
            }
            return closest;
        }

        private bool CalculateAdjustments(FCylinder cylinder, FCylinder neighbor, out float move, out float rotate, out float lengthAdjust)
        {
            move = rotate = lengthAdjust = 0f;

            // Calculate the vector pointing from cylinder to neighbor
            var directionToNeighbor = neighbor.Center - cylinder.Center;

            // Calculate the desired end point for our cylinder to touch the neighbor
            var desiredEndPoint = cylinder.Center + Vector3.Normalize(directionToNeighbor) * (directionToNeighbor.Length() - neighbor.Length / 2 - cylinder.Length / 2);

            // 1. Position Adjustments:
            // Calculate the move amount as the difference between current endpoint and desired endpoint
            var endPointDifference = desiredEndPoint - (cylinder.Center + new Vector3(0, 0, cylinder.Length / 2));
            move = endPointDifference.Length();

            // 2. Orientation Adjustments:
            // Calculate the angle between the cylinder's current direction and the desired direction to the neighbor
            var currentDirection = new Vector3(0, 0, 1);  // Assuming cylinders are oriented along the Z axis
            var dot = Vector3.Dot(currentDirection, Vector3.Normalize(directionToNeighbor));
            rotate = (float)Math.Acos(dot) * (180.0f / (float)Math.PI);

            // 3. Length Adjustments:
            // Adjust the length so that both endpoints of the cylinder touch those of its neighbor
            lengthAdjust = directionToNeighbor.Length() - cylinder.Length - neighbor.Length;

            // Check if adjustments are within the specified limits
            if (move < MinLatticeMove || move > MaxLatticeMove) return false;
            if (rotate < MinLatticeRotate || rotate > MaxLatticeRotate) return false;
            return !(lengthAdjust < MinLatticeLengthAdjust) && !(lengthAdjust > MaxLatticeLengthAdjust);
        }


        private void ApplyAdjustments(FCylinder cylinder, float moveAmount, float rotateAmount, float lengthAdjustAmount)
        {
            // 1. Move the cylinder
            var currentOrientation = Vector3.Transform(new Vector3(0, 0, 1), cylinder.OrientedBoundingBox.Rotation); // Extract orientation from bounding box's rotation matrix
            cylinder.Center += currentOrientation * moveAmount;

            // 2. Rotate the cylinder
            // We rotate around all three axes by the rotateAmount.
            var rotationX = Matrix4x4.CreateRotationX(MathF.PI * rotateAmount / 180.0f);
            var rotationY = Matrix4x4.CreateRotationY(MathF.PI * rotateAmount / 180.0f);
            var rotationZ = Matrix4x4.CreateRotationZ(MathF.PI * rotateAmount / 180.0f);
            var combinedRotation = rotationX * rotationY * rotationZ;

            // Update the bounding box's rotation matrix
            cylinder.OrientedBoundingBox.Rotation = combinedRotation * cylinder.OrientedBoundingBox.Rotation;

            // 3. Adjust the cylinder's length
            cylinder.Length += lengthAdjustAmount;

            // Adjust the bounding box based on the new cylinder dimensions
            var newOrientation = Vector3.Transform(new Vector3(0, 0, 1), cylinder.OrientedBoundingBox.Rotation);
            cylinder.OrientedBoundingBox = new BoundingBox<float>(cylinder.Center, cylinder.Diameter / 2, newOrientation * cylinder.Length);
        }
    }

    public class NSphere
    {
        public Vector3 Center { get; set; }
        public float Diameter { get; set; }
        public BoundingBox<float> OrientedBoundingBox { get; private set; }
        private INoiseAlgorithm _noiseAlgorithm;

        public NSphere(Vector3 center, float diameter, INoiseAlgorithm noiseAlgorithm)
        {
            Center = center;
            Diameter = diameter;
            _noiseAlgorithm = noiseAlgorithm;
            OrientedBoundingBox = new BoundingBox<float>(center, diameter / 2, Vector3.One * diameter);
        }

        public void Warp(INoiseAlgorithm noiseAlgorithm, float warpAmount)
        {
            var displacement = new Vector3(
                (float)noiseAlgorithm.GenerateSpatialSingleSample(new double[] { Center.X }),
                (float)noiseAlgorithm.GenerateSpatialSingleSample(new double[] { Center.Y }),
                (float)noiseAlgorithm.GenerateSpatialSingleSample(new double[] { Center.Z })
            );

            Center += displacement * warpAmount;
            OrientedBoundingBox = new BoundingBox<float>(Center, Diameter / 2, Vector3.One * Diameter);
        }
    }

    public class NSphereGenerator
    {
        private Random _random = new Random();
        public float MinNSphereSize { get; set; }
        public float MaxNSphereSize { get; set; }

        public List<NSphere> GenerateSpheresFromCylinderEnds(List<FCylinder> cylinders, INoiseAlgorithm noiseAlgorithm)
        {
            var spheres = new List<NSphere>();

            foreach (var cylinder in cylinders)
            {
                var direction = Vector3.Transform(new Vector3(0, 0, 1), cylinder.OrientedBoundingBox.Rotation); // Extract direction from cylinder's bounding box
                var endpoint1 = cylinder.Center - direction * cylinder.Length / 2;
                var endpoint2 = cylinder.Center + direction * cylinder.Length / 2;

                // Generate random size within the given limits
                var diameter = (float)(_random.NextDouble() * (MaxNSphereSize - MinNSphereSize) + MinNSphereSize);

                spheres.Add(new NSphere(endpoint1, diameter, noiseAlgorithm));
                spheres.Add(new NSphere(endpoint2, diameter, noiseAlgorithm));
            }

            return spheres;
        }
    }
}