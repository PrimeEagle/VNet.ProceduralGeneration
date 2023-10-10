using System.Numerics;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
#pragma warning disable CA1822
#pragma warning disable IDE0060


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGenerator : ContainerGeneratorBase<CosmicWeb, CosmicWebContext>
{
    protected IRandomGenerationAlgorithm Random;

    public struct Sphere
    {
        public Vector3 Center;
        public float Radius;

        public Sphere(Vector3 center, float radius)
        {
            Center = center;
            Radius = radius;
        }
    }

    public struct WarpedSphere
    {
        public Vector3 Center;
        public float Radius;
        public List<Vector3> SurfacePoints;  // These points represent the warped surface
    }

    public class IntersectionCircle
    {
        public Vector3 Center { get; set; }
        public float Radius { get; set; }
        public float Thickness { get; set; }

        public IntersectionCircle(Vector3 center, float radius, float thickness)
        {
            Center = center;
            Radius = radius;
            Thickness = thickness;
        }
    }

    public class Cylinder
    {
        public Vector3 Center { get; set; }
        public Vector3 Orientation { get; set; }
        public float Height { get; set; }
        public float Radius { get; set; }

        public Cylinder(Vector3 center, Vector3 orientation, float height, float radius)
        {
            Center = center;
            Orientation = orientation;
            Height = height;
            Radius = radius;
        }
    }


    private void GenerateCosmicWebRandomly(CosmicWeb self)
    {

    }

    public List<Sphere> GenerateBaseSpheres(float[,,] volumeMap, float maxCoveragePercentage, float isolatedSpherePercentage)
    {
        var spheres = new List<Sphere>
        {
            Capacity = 0
        };
        float currentCoverage = 0;

        while (currentCoverage < maxCoveragePercentage)
        {
            var x = Random.Next(0, volumeMap.GetLength(0));
            var y = Random.Next(0, volumeMap.GetLength(1));
            var z = Random.Next(0, volumeMap.GetLength(2));

            if (!(volumeMap[x, y, z] < 0.5f)) continue;
            var radius = CalculateRadius(x, y, z, volumeMap);
            var newSphere = new Sphere(new Vector3(x, y, z), radius);

            var isIsolated = IsIsolatedSphere(newSphere, spheres);
            if (Random.NextDouble() * 100 <= isolatedSpherePercentage && isIsolated)
            {
                spheres.Add(newSphere);
                currentCoverage += CalculateSphereVolumePercentage(newSphere, volumeMap);
            }
            else if (!isIsolated)
            {
                spheres.Add(newSphere);
                currentCoverage += CalculateSphereVolumePercentage(newSphere, volumeMap);
            }
        }

        return spheres;
    }

    public WarpedSphere GenerateWarpedSphere(Sphere baseSphere, float warpFactor)
    {
        var warped = new WarpedSphere
        {
            Center = baseSphere.Center,
            Radius = baseSphere.Radius,
            SurfacePoints = new List<Vector3>()
        };

        // Sample points from the sphere and warp them
        var sampleCount = 1000; // You can adjust this for more/less detail
        for (var i = 0; i < sampleCount; i++)
        {
            // Randomly sample a point on the sphere surface
            var pointOnSphere = RandomPointOnSphere(baseSphere.Center, baseSphere.Radius);

            // Compute a displacement based on Perlin noise
            var displacement = (PerlinNoise(pointOnSphere.X, pointOnSphere.Y, pointOnSphere.Z) - 0.5f) * warpFactor;

            // Displace the point outward/inward
            var outwardDirection = Vector3.Normalize(pointOnSphere - baseSphere.Center);
            var warpedPoint = pointOnSphere + outwardDirection * displacement;

            warped.SurfacePoints.Add(warpedPoint);
        }

        return warped;
    }

    public List<IntersectionCircle> FindWarpedIntersections(List<WarpedSphere> spheres)
    {
        List<IntersectionCircle> intersections = new();

        for (var i = 0; i < spheres.Count; i++)
        {
            for (var j = i + 1; j < spheres.Count; j++)
            {
                var distanceBetweenCenters = Vector3.Distance(spheres[i].Center, spheres[j].Center);
                var totalRadii = spheres[i].Radius + spheres[j].Radius;

                if (!(distanceBetweenCenters < totalRadii)) continue; // If the spheres intersect
                var intersectionCenter = spheres[i].Center + (spheres[j].Center - spheres[i].Center) / 2;
                var intersectionRadius = (totalRadii - distanceBetweenCenters) / 2;
                var intersectionThickness = totalRadii - distanceBetweenCenters; // Calculate the thickness

                intersections.Add(new IntersectionCircle(intersectionCenter, intersectionRadius, intersectionThickness));
            }
        }

        return intersections;
    }


    private bool IsIsolatedSphere(Sphere newSphere, List<Sphere> existingSpheres)
    {
        foreach (var sphere in existingSpheres)
        {
            var distance = Vector3.Distance(newSphere.Center, sphere.Center);
            var combinedRadius = newSphere.Radius + sphere.Radius;

            if (distance <= combinedRadius) // If spheres overlap or touch
            {
                return false;
            }
        }
        return true;
    }

    private float CalculateRadius(int x, int y, int z, float[,,] volumeMap)
    {
        var count = 0;
        float sum = 0;

        for (var i = -1; i <= 1; i++)
        {
            for (var j = -1; j <= 1; j++)
            {
                for (var k = -1; k <= 1; k++)
                {
                    if (!IsInBounds(x + i, y + j, z + k, volumeMap)) continue;
                    sum += volumeMap[x + i, y + j, z + k];
                    count++;
                }
            }
        }

        var avg = sum / count;
        return (0.5f - avg) + ((float)Random.NextDouble() * 0.1f);
    }

    private bool IsInBounds(int x, int y, int z, float[,,] volumeMap)
    {
        return x >= 0 && x < volumeMap.GetLength(0) &&
               y >= 0 && y < volumeMap.GetLength(1) &&
               z >= 0 && z < volumeMap.GetLength(2);
    }

    private float CalculateSphereVolumePercentage(Sphere sphere, float[,,] volumeMap)
    {
        var sphereVolume = (4.0f / 3.0f) * (float)Math.PI * (float)Math.Pow(sphere.Radius, 3);
        float totalVolume = volumeMap.GetLength(0) * volumeMap.GetLength(1) * volumeMap.GetLength(2);
        return (sphereVolume / totalVolume) * 100;
    }

    private bool IsPointInsideSphere(Vector3 point, WarpedSphere sphere)
    {
        var distance = Vector3.Distance(point, sphere.Center);
        return distance < sphere.Radius;
    }

    private Vector3 RandomPointOnSphere(Vector3 center, float radius)
    {
        var theta = (float)(2 * Math.PI * Random.NextDouble());
        var phi = (float)(Math.Acos(2 * Random.NextDouble() - 1));
        var x = center.X + radius * (float)Math.Sin(phi) * (float)Math.Cos(theta);
        var y = center.Y + radius * (float)Math.Sin(phi) * (float)Math.Sin(theta);
        var z = center.Z + radius * (float)Math.Cos(phi);
        return new Vector3(x, y, z);
    }

    private bool TryGetIntersectionCircle(WarpedSphere a, WarpedSphere b, out IntersectionCircle circle)
    {
        circle = default;

        var d = b.Center - a.Center;
        var dist = d.Length();

        if (dist > a.Radius + b.Radius || dist < Math.Abs(a.Radius - b.Radius))
            return false;

        var aToCenter = ((a.Radius * a.Radius) - (b.Radius * b.Radius) + (dist * dist)) / (2.0f * dist);
        var center = a.Center + aToCenter * Vector3.Normalize(d);
        var circleRadius = (float)Math.Sqrt((a.Radius * a.Radius) - (aToCenter * aToCenter));

        circle = new IntersectionCircle(center, circleRadius, dist);
        return true;
    }

    // Placeholder for Perlin noise. In Unity, use Mathf.PerlinNoise.
    private float PerlinNoise(float x, float y, float z)
    {
        return 0.5f;  // Placeholder
    }

    private List<Vector3> GetCircleIntersections(IntersectionCircle circle1, IntersectionCircle circle2)
    {
        var d = Vector3.Distance(circle1.Center, circle2.Center);

        // No intersection if one circle is within the other or if they are too far apart
        if (d > circle1.Radius + circle2.Radius || d < Math.Abs(circle1.Radius - circle2.Radius))
            return new List<Vector3>();

        var a = (circle1.Radius * circle1.Radius - circle2.Radius * circle2.Radius + d * d) / (2.0f * d);
        var h = (float)Math.Sqrt(circle1.Radius * circle1.Radius - a * a);

        var direction = Vector3.Normalize(circle2.Center - circle1.Center);
        var pa = circle1.Center + a * direction;
        var pb = circle1.Center + (a + d) * direction;

        var intersection1 = pa + h * new Vector3(-direction.Z, 0, direction.X);
        var intersection2 = pa - h * new Vector3(-direction.Z, 0, direction.X);

        return new List<Vector3> { intersection1, intersection2 };
    }

    public List<Cylinder> GenerateCylindersFromIntersections(List<IntersectionCircle> intersections)
    {
        List<Cylinder> cylinders = new();

        for (var i = 0; i < intersections.Count; i++)
        {
            for (var j = i + 1; j < intersections.Count; j++)
            {
                var intersectionPoints = GetCircleIntersections(intersections[i], intersections[j]);

                if (intersectionPoints.Count == 2)  // We need exactly two intersection points to create a cylinder
                {
                    var pointA = intersectionPoints[0];
                    var pointB = intersectionPoints[1];

                    // Calculate the midpoint as the center of the cylinder
                    var cylinderCenter = (pointA + pointB) / 2.0f;

                    // Use the segment connecting the intersection points as the cylinder's orientation
                    var cylinderOrientation = Vector3.Normalize(pointB - pointA);

                    // Use the distance between the intersection points as the height of the cylinder
                    var cylinderHeight = Vector3.Distance(pointA, pointB);

                    // The radius of the cylinder can be a predetermined value, or some function of the two intersecting circles
                    var cylinderRadius = Math.Min(intersections[i].Radius, intersections[j].Radius);  // This is just one option

                    cylinders.Add(new Cylinder(cylinderCenter, cylinderOrientation, cylinderHeight, cylinderRadius));
                }
            }
        }

        return cylinders;
    }

    private bool TryConnectCylinderEnds(Cylinder c1, Cylinder c2)
    {
        const float MAX_ALLOWABLE_DISTANCE = SOME_THRESHOLD;  // Define a reasonable threshold for connection

        // Calculate the end points of both cylinders
        var c1End1 = c1.Center + (c1.Height / 2) * c1.Orientation;
        var c1End2 = c1.Center - (c1.Height / 2) * c1.Orientation;

        var c2End1 = c2.Center + (c2.Height / 2) * c2.Orientation;
        var c2End2 = c2.Center - (c2.Height / 2) * c2.Orientation;

        // Determine the closest ends between the two cylinders
        var dist1 = Vector3.Distance(c1End1, c2End1);
        var dist2 = Vector3.Distance(c1End1, c2End2);
        var dist3 = Vector3.Distance(c1End2, c2End1);
        var dist4 = Vector3.Distance(c1End2, c2End2);

        var minDist = Math.Min(Math.Min(dist1, dist2), Math.Min(dist3, dist4));

        // If the closest ends are too far apart, return false
        if (minDist > MAX_ALLOWABLE_DISTANCE) return false;

        // If ends are close enough, adjust the position and orientation of one of the cylinders to connect them
        var targetEnd = Vector3.Zero;
        if (minDist == dist1)
        {
            // Adjust c1End1 to c2End1
            targetEnd = c2End1;
        }
        else if (minDist == dist2)
        {
            // Adjust c1End1 to c2End2
            targetEnd = c2End2;
        }
        else if (minDist == dist3)
        {
            // Adjust c1End2 to c2End1
            targetEnd = c2End1;
        }
        else if (minDist == dist4)
        {
            // Adjust c1End2 to c2End2
            targetEnd = c2End2;
        }

        AdjustCylinderToEnd(c1, targetEnd);

        return true;
    }

    // This helper function adjusts a cylinder's position and orientation to connect its end to a target point
    private void AdjustCylinderToEnd(Cylinder cylinder, Vector3 targetPoint)
    {
        // Adjust orientation
        var start = cylinder.Center - (cylinder.Height / 2) * cylinder.Orientation;
        var direction = Vector3.Normalize(targetPoint - start);
        cylinder.Orientation = direction;

        // Adjust position
        var diff = targetPoint - (cylinder.Center + (cylinder.Height / 2) * cylinder.Orientation);
        cylinder.Center += diff;
    }


    private bool TryConnectCylinderMiddles(Cylinder c1, Cylinder c2)
    {
        const float MAX_ALLOWABLE_DISTANCE = SOME_THRESHOLD;

        // Get the center of c1
        var centerC1 = c1.Center;

        // Get closest point on c2 to the center of c1
        var closestPointOnC2 = GetClosestPointOnCylinder(centerC1, c2);

        var distance = Vector3.Distance(centerC1, closestPointOnC2);

        if (distance > MAX_ALLOWABLE_DISTANCE) return false;

        AdjustCylinderToTargetPoint(c1, closestPointOnC2);

        return true;
    }

    private Vector3 GetClosestPointOnCylinder(Vector3 point, Cylinder cylinder)
    {
        // First, check the ends of the cylinder
        var end1 = cylinder.Center + (cylinder.Height / 2) * cylinder.Orientation;
        var end2 = cylinder.Center - (cylinder.Height / 2) * cylinder.Orientation;

        var distanceToEnd1 = Vector3.Distance(point, end1);
        var distanceToEnd2 = Vector3.Distance(point, end2);

        if (distanceToEnd1 < distanceToEnd2)
        {
            return end1;
        }
        else if (distanceToEnd2 < distanceToEnd1)
        {
            return end2;
        }

        // If neither end is the clear closest, sample points along the cylinder's length
        const int SAMPLE_POINTS = 10;

        var closestPoint = Vector3.Zero;
        var minDistance = float.MaxValue;

        for (var i = 0; i <= SAMPLE_POINTS; i++)
        {
            var fraction = (float)i / SAMPLE_POINTS;
            var samplePoint = cylinder.Center + (cylinder.Height * fraction - cylinder.Height / 2) * cylinder.Orientation;

            var distance = Vector3.Distance(point, samplePoint);
            if (!(distance < minDistance)) continue;
            minDistance = distance;
            closestPoint = samplePoint;
        }

        return closestPoint;
    }

    private void AdjustCylinderToTargetPoint(Cylinder cylinder, Vector3 targetPoint)
    {
        // Adjust orientation so the cylinder is pointing towards the target point
        var direction = Vector3.Normalize(targetPoint - cylinder.Center);
        cylinder.Orientation = direction;

        // Adjust position so that the cylinder intersects the target point
        var moveVector = targetPoint - (cylinder.Center + (cylinder.Height / 2) * cylinder.Orientation);
        cylinder.Center += moveVector;
    }


    private bool ShouldRemoveCylinder(Cylinder cylinder, List<Cylinder> allCylinders)
    {
        var intersectionCount = 0;

        foreach (var otherCylinder in allCylinders)
        {
            if (otherCylinder != cylinder)
            {
                if (GetIntersections(cylinder, otherCylinder).Count > 0)
                {
                    intersectionCount++;
                }
            }

            // Early exit if we already found 2 intersections
            if (intersectionCount >= 2)
                break;
        }

        return intersectionCount < 2;
    }


    private bool ShouldShortenCylinder(Cylinder cylinder, List<Cylinder> allCylinders)
    {
        const float END_THRESHOLD = 0.1f;  // Distance from end to consider it an end intersection

        var intersectionPoints = new List<Vector3>();

        foreach (var otherCylinder in allCylinders)
        {
            if (otherCylinder == cylinder) continue;
            // This is a simple approach and assumes you have a method to get intersection points of two cylinders
            var intersections = GetIntersections(cylinder, otherCylinder);
            intersectionPoints.AddRange(intersections);
        }

        if (intersectionPoints.Count < 2) return false;

        var endIntersections = 0;
        var end1 = cylinder.Center + (cylinder.Height / 2) * cylinder.Orientation;
        var end2 = cylinder.Center - (cylinder.Height / 2) * cylinder.Orientation;

        foreach (var point in intersectionPoints)
        {
            var distanceToEnd1 = Vector3.Distance(point, end1);
            var distanceToEnd2 = Vector3.Distance(point, end2);

            if (distanceToEnd1 < END_THRESHOLD || distanceToEnd2 < END_THRESHOLD)
            {
                endIntersections++;
            }
        }

        return endIntersections < 2; // if both ends aren't intersecting
    }

    private List<Vector3> GetIntersections(Cylinder c1, Cylinder c2)
    {
        var intersections = new List<Vector3>();

        // 1. Bounding sphere test
        float combinedRadii = (c1.Diameter / 2) + (c2.Diameter / 2);
        if (Vector3.Distance(c1.Center, c2.Center) > combinedRadii + c1.Height + c2.Height)
            return intersections; // No intersections

        // 2. Segment-segment intersection (just a confirmation)
        if (!SegmentsIntersect(c1, c2))
            return intersections;

        // 3. Sample points for exact intersections
        const int SAMPLE_POINTS = 10;
        for (var i = 0; i <= SAMPLE_POINTS; i++)
        {
            var fraction = (float)i / SAMPLE_POINTS;
            var pointOnC1 = c1.Center + (c1.Height * fraction - c1.Height / 2) * c1.Orientation;

            if (PointInsideCylinder(pointOnC1, c2))
            {
                intersections.Add(pointOnC1);
            }
        }

        return intersections;
    }

    private bool SegmentsIntersect(Cylinder c1, Cylinder c2)
    {
        var p = c1.Center - (c1.Height / 2) * c1.Orientation;  // Start point of c1's segment
        var q = c2.Center - (c2.Height / 2) * c2.Orientation;  // Start point of c2's segment
        var r = c1.Orientation * c1.Height;  // Direction vector for c1's segment
        var s = c2.Orientation * c2.Height;  // Direction vector for c2's segment

        var rxs = Vector3.Cross(r, s).Length();
        var qmp = q - p;

        if (rxs == 0)
        {
            // The segments are parallel
            if (Vector3.Cross(qmp, r).Length() != 0) return false; // They are parallel but not collinear
            // The segments are collinear
            var t0 = Vector3.Dot(qmp, r) / Vector3.Dot(r, r);
            var t1 = t0 + Vector3.Dot(s, r) / Vector3.Dot(r, r);

            // Check if the segments overlap
            return t0 is <= 1 and >= 0 || t1 is <= 1 and >= 0 || (t0 < 0 && t1 > 1) || (t0 > 1 && t1 < 0);
        }

        var t = Vector3.Dot(Vector3.Cross(qmp, s), r) / rxs;
        var u = Vector3.Dot(Vector3.Cross(qmp, r), s) / rxs;

        // If t is between 0 and 1 and u is between 0 and 1, the segments intersect
        return t is <= 1 and >= 0 && u is <= 1 and >= 0;
    }


    private bool PointInsideCylinder(Vector3 point, Cylinder cylinder)
    {
        // Check if the point lies within the height range of the cylinder
        var distanceAlongAxis = Vector3.Dot(point - cylinder.Center, cylinder.Orientation);
        if (Math.Abs(distanceAlongAxis) > cylinder.Height / 2) return false;

        // Check if the point lies within the diameter of the cylinder
        var projectionOnAxis = cylinder.Center + distanceAlongAxis * cylinder.Orientation;
        var distanceFromAxis = Vector3.Distance(point, projectionOnAxis);
        return distanceFromAxis <= cylinder.Diameter / 2;
    }

    private List<WarpedSphere> CreateWarpedSpheresAtIntersections(List<Cylinder> allCylinders)
    {
        var warpedSpheres = new List<WarpedSphere>();

        // Iterate over all pairs of cylinders
        for (var i = 0; i < allCylinders.Count; i++)
        {
            for (var j = i + 1; j < allCylinders.Count; j++)
            {
                var c1 = allCylinders[i];
                var c2 = allCylinders[j];

                // Get the intersection points of the two cylinders
                var intersectionPoints = GetIntersections(c1, c2);

                foreach (var intersection in intersectionPoints)
                {
                    // Determine the diameter of the sphere based on the diameters of the intersecting cylinders
                    float sphereDiameter = Math.Max(c1.Diameter, c2.Diameter) * SOME_MULTIPLIER;  // Adjust the multiplier as needed

                    var sphere = new WarpedSphere
                    {
                        Center = intersection,
                        Radius = sphereDiameter / 2,
                        SurfacePoints = GenerateWarpedSurfacePoints(intersection, sphereDiameter / 2)
                    };

                    warpedSpheres.Add(sphere);
                }
            }
        }

        return warpedSpheres;
    }

    private List<Vector3> GenerateWarpedSurfacePoints(Vector3 center, float radius)
    {
        var warpedPoints = new List<Vector3>();
        var rnd = new Random();

        const int POINT_COUNT = 100;  // You can adjust this based on the desired detail level
        for (var i = 0; i < POINT_COUNT; i++)
        {
            // Generate random spherical coordinates
            var theta = (float)rnd.NextDouble() * 2 * MathF.PI;  // azimuthal angle
            var phi = MathF.Acos(2 * (float)rnd.NextDouble() - 1);  // polar angle

            // Convert spherical coordinates to Cartesian
            var pointOnSphere = new Vector3
            {
                X = center.X + radius * MathF.Sin(phi) * MathF.Cos(theta),
                Y = center.Y + radius * MathF.Sin(phi) * MathF.Sin(theta),
                Z = center.Z + radius * MathF.Cos(phi)
            };

            // Apply a random perturbation to simulate warping
            var perturbation = (float)(rnd.NextDouble() - 0.5) * SOME_PERTURBATION_FACTOR;  // Adjust the factor for desired warp effect
            var warpedPoint = pointOnSphere + perturbation * Vector3.Normalize(pointOnSphere - center);

            warpedPoints.Add(warpedPoint);
        }

        return warpedPoints;
    }
}