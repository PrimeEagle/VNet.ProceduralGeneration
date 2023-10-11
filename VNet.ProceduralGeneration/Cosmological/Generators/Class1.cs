using System.Numerics;
using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;
using VNet.Scientific.NumericalVolumes;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CA1822
#pragma warning disable CS8618

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public class VSphere
    {
        public Vector3 Center { get; }
        public float Diameter { get; }
        public BoundingBox<float> OrientedBoundingBox { get; set; }
        public List<Vector3> Points { get; private set; }
        public INoiseAlgorithm NoiseAlgorithm { get; set; }
        public IRandomGenerationAlgorithm RandomAlgorithm { get; set; }
        
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
        public float PercentageOfVolumeCoveredBySpheres { get; set; }
        public float MinSphereSize { get; set; }
        public float MaxSphereSize { get; set; }
        public float PercentageOfOverlappingSpheres { get; set; }
        public float MinOverlapAmount { get; set; }
        public float MaxOverlapAmount { get; set; }
        public IRandomGenerationAlgorithm RandomAlgorithm { get; set; }
        
        public List<VSphere> GenerateSpheres(float[,,] volume)
        {
            var volumeSize = volume.GetLength(0) * volume.GetLength(1) * volume.GetLength(2);
            var targetSphereVolume = volumeSize * PercentageOfVolumeCoveredBySpheres;
            var spheres = new List<VSphere>();

            while (targetSphereVolume > 0)
            {
                var diameter = RandomAlgorithm.NextSingle() * (MaxSphereSize - MinSphereSize) + MinSphereSize;
                var sphereVolume = (float)(4.0 / 3.0 * Math.PI * Math.Pow(diameter / 2, 3));

                if (sphereVolume > targetSphereVolume)
                {
                    diameter = (float)Math.Pow(targetSphereVolume * 3.0 / (4.0 * Math.PI), 1.0 / 3.0) * 2;
                    sphereVolume = targetSphereVolume;
                }

                var center = new Vector3(
                    RandomAlgorithm.NextSingle() * (volume.GetLength(0) - diameter),
                    RandomAlgorithm.NextSingle() * (volume.GetLength(1) - diameter),
                    RandomAlgorithm.NextSingle() * (volume.GetLength(2) - diameter)
                );

                var sphere = new VSphere(center, diameter);

                var acceptableOverlap = false;
                while (!acceptableOverlap)
                {
                    var overlapAmount = CalculateOverlapAmount(sphere, spheres);

                    if (overlapAmount < MinOverlapAmount || overlapAmount > MaxOverlapAmount)
                    {
                        sphere = new VSphere(new Vector3(
                            RandomAlgorithm.NextSingle() * (volume.GetLength(0) - diameter),
                            RandomAlgorithm.NextSingle() * (volume.GetLength(1) - diameter),
                            RandomAlgorithm.NextSingle() * (volume.GetLength(2) - diameter)
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
        public Vector3 OrientationNormal { get; set; }

        public BoundingBox<float> OrientedBoundingBox { get; set; }
        public List<Vector3> Points { get; private set; }
        public INoiseAlgorithm NoiseAlgorithm { get; set; }
        public IRandomGenerationAlgorithm RandomAlgorithm { get; set; }


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
            var defaultOrientation = new Vector3(0, 0, 1);
            var rotationAxis = Vector3.Cross(defaultOrientation, this.OrientationNormal);

            rotationAxis = rotationAxis.LengthSquared() < 1e-10 ? defaultOrientation : Vector3.Normalize(rotationAxis);
            var dot = Vector3.Dot(defaultOrientation, this.OrientationNormal);
            var rotationAngle = (float)Math.Acos(Math.Clamp(dot, -1.0f, 1.0f));

            var rotation = Quaternion.CreateFromAxisAngle(rotationAxis, rotationAngle);

            var rotationMatrix = Matrix4x4.CreateFromQuaternion(rotation);
            this.OrientedBoundingBox = new BoundingBox<float>(this.Center, this.Diameter / 2, Vector3.Transform(new Vector3(this.Diameter, this.Diameter, this.Thickness), rotationMatrix));
        }

        public void Warp(float warpAmount)
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

                var warpFactorXy = (float)NoiseAlgorithm.GenerateSpatialSingleSample(new double[] { pointOnCircle.X, pointOnCircle.Y });
                var warpedPoint = pointOnCircle + Vector3.Normalize(pointOnCircle - Center) * warpFactorXy * warpAmount;

                Points.Add(warpedPoint);
            }
        }
    }

    public class RandomCircleGenerator
    {
        public float MinThickness { get; set; }
        public float MaxThickness { get; set; }
        public IRandomGenerationAlgorithm RandomAlgorithm { get; set; }

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

                    if (!(distance < combinedRadii)) continue;

                    var direction = Vector3.Normalize(sphere2.Center - sphere1.Center);
                    var circleCenter = sphere1.Center + direction * (sphere1.Diameter / 2);
                    var approxCircleDiameter = combinedRadii - distance;
                    var thickness = RandomAlgorithm.NextSingle() * (MaxThickness - MinThickness) + MinThickness;
                    var circle = new SCircle(circleCenter, approxCircleDiameter, thickness)
                    {
                        OrientationNormal = direction
                    };
                    circle.UpdateBoundingBox();

                    circles.Add(circle);
                }
            }

            return circles;
        }
    }
    
    public class FCylinder
    {
        private Vector3 _direction;
        public Vector3 Center { get; set; }
        public float Diameter { get; }
        public float Length { get; set; }
        public Vector3 Direction
        {
            get => _direction;
            set
            {
                var currentDirection = _direction;
                var targetDirection = Vector3.Normalize(value);
                var rotationAxis = Vector3.Cross(currentDirection, targetDirection);
                var dot = Vector3.Dot(currentDirection, targetDirection);
                var rotationAngle = (float)Math.Acos(dot);
                var rotation = Quaternion.CreateFromAxisAngle(rotationAxis, rotationAngle);

                this.OrientedBoundingBox.Rotation = Matrix4x4.CreateFromQuaternion(rotation);
                _direction = targetDirection;

                UpdateBoundingBox();
            }
        }
        public BoundingBox<float> OrientedBoundingBox { get; set; }
        public List<Vector3> Points { get; private set; }
        public INoiseAlgorithm NoiseAlgorithm { get; set; }
        public IRandomGenerationAlgorithm RandomAlgorithm { get; set; }

        public void UpdateBoundingBox()
        {
            var defaultOrientation = new Vector3(0, 0, 1);
            var rotationAxis = Vector3.Cross(defaultOrientation, _direction);

            rotationAxis = rotationAxis.LengthSquared() < 1e-10 ? defaultOrientation :
                Vector3.Normalize(rotationAxis);

            var dot = Vector3.Dot(defaultOrientation, _direction);
            var rotationAngle = (float)Math.Acos(Math.Clamp(dot, -1.0f, 1.0f));
            var rotation = Quaternion.CreateFromAxisAngle(rotationAxis, rotationAngle);
            var rotationMatrix = Matrix4x4.CreateFromQuaternion(rotation);
            this.OrientedBoundingBox = new BoundingBox<float>(this.Center, this.Diameter / 2, Vector3.Transform(new Vector3(this.Diameter, this.Diameter, this.Length), rotationMatrix));
        }

        public FCylinder(Vector3 center, float diameter, float length)
        {
            Center = center;
            Diameter = diameter;
            Length = length;
            OrientedBoundingBox = new BoundingBox<float>(center, Diameter / 2, new Vector3(Diameter, Diameter, Length));
            Points = new List<Vector3>();
        }

        public void Warp(float warpAmount)
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
        public List<FCylinder> GenerateCylindersFromIntersections(List<SCircle> circles)
        {
            var cylinders = new List<FCylinder>();

            for (var i = 0; i < circles.Count; i++)
            {
                for (var j = i + 1; j < circles.Count; j++)
                {
                    var circle1 = circles[i];
                    var circle2 = circles[j];

                    if (!GetCircleIntersection(circle1, circle2, out var intersection1, out var intersection2)) continue;

                    var cylinderCenter = (intersection1 + intersection2) / 2;
                    var cylinderDirection = Vector3.Normalize(intersection2 - intersection1);
                    var cylinderLength = Vector3.Distance(intersection1, intersection2);
                    var cylinderDiameter = Math.Min(circle1.Diameter, circle2.Diameter);

                    var newCylinder = new FCylinder(cylinderCenter, cylinderDiameter, cylinderLength)
                    {
                        Direction = cylinderDirection
                    };

                    cylinders.Add(newCylinder);
                }
            }

            return cylinders;
        }

        private bool GetCircleIntersection(SCircle c1, SCircle c2, out Vector3 intersection1, out Vector3 intersection2)
        {
            intersection1 = new Vector3();
            intersection2 = new Vector3();

            var lineDirection = Vector3.Cross(c1.OrientationNormal, c2.OrientationNormal);
            if (lineDirection.LengthSquared() < 1e-10)
                return false;

            lineDirection = Vector3.Normalize(lineDirection);

            var t = Vector3.Dot(c1.OrientationNormal, (c1.Center - c2.Center)) / Vector3.Dot(c1.OrientationNormal, lineDirection);
            var intersectionPoint = c2.Center + t * lineDirection;
            var distanceToC1 = Vector3.Distance(c1.Center, intersectionPoint);
            var distanceToC2 = Vector3.Distance(c2.Center, intersectionPoint);

            if (distanceToC1 > c1.Diameter / 2 || distanceToC2 > c2.Diameter / 2)
                return false;

            var distanceFromCenterToIntersection = Math.Sqrt((c1.Diameter / 2 * c1.Diameter / 2) - (distanceToC1 * distanceToC1));
            intersection1 = intersectionPoint + lineDirection * (float)distanceFromCenterToIntersection;
            intersection2 = intersectionPoint - lineDirection * (float)distanceFromCenterToIntersection;

            return true;
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
                        break;
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
                    var canAdjust = CalculateAdjustments(cylinder, closestNeighbor, out var moveAmount, out var rotateAmount, out var lengthAdjustAmount);

                    if (canAdjust)
                    {
                        ApplyAdjustments(cylinder, moveAmount, rotateAmount, lengthAdjustAmount);
                        adjusted = true;
                    }
                    else
                    {
                        cylinders.RemoveAt(i);
                        i--;
                    }
                }
            }

            return cylinders;
        }

        private FCylinder? FindClosestNeighbor(FCylinder cylinder, List<FCylinder> cylinders)
        {
            var minDistance = float.MaxValue;
            FCylinder? closest = null;
            foreach (var other in cylinders)
            {
                if (other == cylinder) continue;

                var distance = Vector3.Distance(cylinder.Center, other.Center);
                if (!(distance < minDistance)) continue;
                minDistance = distance;
                closest = other;
            }
            return closest;
        }

        private bool CalculateAdjustments(FCylinder cylinder, FCylinder neighbor, out float move, out float rotate, out float lengthAdjust)
        {
            var directionToNeighbor = neighbor.Center - cylinder.Center;
            var desiredEndPoint = cylinder.Center + Vector3.Normalize(directionToNeighbor) * (directionToNeighbor.Length() - neighbor.Length / 2 - cylinder.Length / 2);

            var endPointDifference = desiredEndPoint - (cylinder.Center + cylinder.Direction * cylinder.Length / 2);
            move = endPointDifference.Length();

            var currentDirection = cylinder.Direction;  // Fetch the cylinder's current orientation
            var dot = Vector3.Dot(currentDirection, Vector3.Normalize(directionToNeighbor));
            rotate = (float)Math.Acos(dot) * (180.0f / (float)Math.PI);

            lengthAdjust = directionToNeighbor.Length() - cylinder.Length - neighbor.Length;

            if (move < MinLatticeMove || move > MaxLatticeMove) return false;
            if (rotate < MinLatticeRotate || rotate > MaxLatticeRotate) return false;
            return !(lengthAdjust < MinLatticeLengthAdjust) && !(lengthAdjust > MaxLatticeLengthAdjust);
        }

        private void ApplyAdjustments(FCylinder cylinder, float moveAmount, float rotateAmount, float lengthAdjustAmount)
        {
            var currentOrientation = Vector3.Transform(new Vector3(0, 0, 1), cylinder.OrientedBoundingBox.Rotation);
            cylinder.Center += currentOrientation * moveAmount;

            var rotationX = Matrix4x4.CreateRotationX(MathF.PI * rotateAmount / 180.0f);
            var rotationY = Matrix4x4.CreateRotationY(MathF.PI * rotateAmount / 180.0f);
            var rotationZ = Matrix4x4.CreateRotationZ(MathF.PI * rotateAmount / 180.0f);
            var combinedRotation = rotationX * rotationY * rotationZ;

            cylinder.OrientedBoundingBox.Rotation = combinedRotation * cylinder.OrientedBoundingBox.Rotation;
            cylinder.Length += lengthAdjustAmount;

            var newOrientation = Vector3.Transform(new Vector3(0, 0, 1), cylinder.OrientedBoundingBox.Rotation);
            cylinder.OrientedBoundingBox = new BoundingBox<float>(cylinder.Center, cylinder.Diameter / 2, newOrientation * cylinder.Length);
        }
    }

    public class NSphere
    {
        public Vector3 Center { get; set; }
        public float Diameter { get; set; }
        public BoundingBox<float> OrientedBoundingBox { get; private set; }
        public readonly INoiseAlgorithm NoiseAlgorithm;

        public NSphere(Vector3 center, float diameter, INoiseAlgorithm noiseAlgorithm)
        {
            Center = center;
            Diameter = diameter;
            NoiseAlgorithm = noiseAlgorithm;
            OrientedBoundingBox = new BoundingBox<float>(center, diameter / 2, Vector3.One * diameter);
        }

        public void Warp(float warpAmount)
        {
            var displacement = new Vector3(
                (float)NoiseAlgorithm.GenerateSpatialSingleSample(new double[] { Center.X }),
                (float)NoiseAlgorithm.GenerateSpatialSingleSample(new double[] { Center.Y }),
                (float)NoiseAlgorithm.GenerateSpatialSingleSample(new double[] { Center.Z })
            );

            Center += displacement * warpAmount;
            OrientedBoundingBox = new BoundingBox<float>(Center, Diameter / 2, Vector3.One * Diameter);
        }
    }

    public class NSphereGenerator
    {
        public float MinNSphereSize { get; set; }
        public float MaxNSphereSize { get; set; }
        public IRandomGenerationAlgorithm RandomAlgorithm { get; set; }


        public List<NSphere> GenerateSpheresFromCylinderEnds(List<FCylinder> cylinders, INoiseAlgorithm noiseAlgorithm)
        {
            var spheres = new List<NSphere>();

            foreach (var cylinder in cylinders)
            {
                var direction = Vector3.Transform(new Vector3(0, 0, 1), cylinder.OrientedBoundingBox.Rotation);
                var endpoint1 = cylinder.Center - direction * cylinder.Length / 2;
                var endpoint2 = cylinder.Center + direction * cylinder.Length / 2;
                var diameter = RandomAlgorithm.NextSingle() * (MaxNSphereSize - MinNSphereSize) + MinNSphereSize;

                spheres.Add(new NSphere(endpoint1, diameter, noiseAlgorithm));
                spheres.Add(new NSphere(endpoint2, diameter, noiseAlgorithm));
            }

            return spheres;
        }
    }
}