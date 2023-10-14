using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : VoidGeneratorBase<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }
}

public class SphereGenerator
{
    private static readonly Random random = new();

    public List<Sphere> GenerateBaseSpheres(float[,,] volumeMap, float maxCoveragePercentage, float isolatedSpherePercentage)
    {
        var spheres = new List<Sphere>();
        float currentCoverage = 0;

        while (currentCoverage < maxCoveragePercentage)
        {
            var x = random.Next(0, volumeMap.GetLength(0));
            var y = random.Next(0, volumeMap.GetLength(1));
            var z = random.Next(0, volumeMap.GetLength(2));

            if (!(volumeMap[x, y, z] < 0.5f)) continue; // Threshold can be adjusted
            var radius = CalculateRadius(x, y, z, volumeMap);
            var newSphere = new Sphere(new Vector3(x, y, z), radius);

            var isIsolated = IsIsolatedSphere(newSphere, spheres);
            if (random.NextDouble() * 100 <= isolatedSpherePercentage && isIsolated)
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
            BaseRadius = baseSphere.Radius,
            SurfacePoints = new List<Vector3>()
        };

        // Sample points from the sphere and warp them
        const int sampleCount = 1000; // You can adjust this for more/less detail
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

    public List<IntersectionCircle> FindWarpedIntersections(List<WarpedSphere> warpedSpheres)
    {
        var intersectionCircles = new List<IntersectionCircle>();

        for (var i = 0; i < warpedSpheres.Count; i++)
            for (var j = i + 1; j < warpedSpheres.Count; j++)
            {
                // Check warped points of sphere A against base of sphere B
                foreach (var point in warpedSpheres[i].SurfacePoints.Where(point => IsPointInsideSphere(point, warpedSpheres[j])))
                {
                    if (!TryGetIntersectionCircle(warpedSpheres[i], warpedSpheres[j], out var circle)) continue;
                    intersectionCircles.Add(circle);
                    break; // No need to check further for this pair
                }

                // Check warped points of sphere B against base of sphere A
                foreach (var point in warpedSpheres[j].SurfacePoints.Where(point => IsPointInsideSphere(point, warpedSpheres[i])))
                {
                    if (!TryGetIntersectionCircle(warpedSpheres[i], warpedSpheres[j], out var circle)) continue;
                    intersectionCircles.Add(circle);
                    break; // No need to check further for this pair
                }
            }

        return intersectionCircles;
    }

    private bool IsIsolatedSphere(Sphere newSphere, List<Sphere> existingSpheres)
    {
        foreach (var sphere in existingSpheres)
        {
            var distance = Vector3.Distance(newSphere.Center, sphere.Center);
            var combinedRadius = newSphere.Radius + sphere.Radius;

            if (distance <= combinedRadius) // If spheres overlap or touch
                return false;
        }

        return true;
    }

    private float CalculateRadius(int x, int y, int z, float[,,] volumeMap)
    {
        var count = 0;
        float sum = 0;

        for (var i = -1; i <= 1; i++)
            for (var j = -1; j <= 1; j++)
                for (var k = -1; k <= 1; k++)
                    if (IsInBounds(x + i, y + j, z + k, volumeMap))
                    {
                        sum += volumeMap[x + i, y + j, z + k];
                        count++;
                    }

        var avg = sum / count;
        return 0.5f - avg + (float)random.NextDouble() * 0.1f;
    }

    private bool IsInBounds(int x, int y, int z, float[,,] volumeMap)
    {
        return x >= 0 && x < volumeMap.GetLength(0) &&
               y >= 0 && y < volumeMap.GetLength(1) &&
               z >= 0 && z < volumeMap.GetLength(2);
    }

    private float CalculateSphereVolumePercentage(Sphere sphere, float[,,] volumeMap)
    {
        var sphereVolume = 4.0f / 3.0f * (float)Math.PI * (float)Math.Pow(sphere.Radius, 3);
        float totalVolume = volumeMap.GetLength(0) * volumeMap.GetLength(1) * volumeMap.GetLength(2);
        return sphereVolume / totalVolume * 100;
    }

    private bool IsPointInsideSphere(Vector3 point, WarpedSphere sphere)
    {
        var distance = Vector3.Distance(point, sphere.Center);
        return distance < sphere.BaseRadius;
    }

    private Vector3 RandomPointOnSphere(Vector3 center, float radius)
    {
        var theta = (float)(2 * Math.PI * random.NextDouble());
        var phi = (float)Math.Acos(2 * random.NextDouble() - 1);
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

        if (dist > a.BaseRadius + b.BaseRadius || dist < Math.Abs(a.BaseRadius - b.BaseRadius))
            return false;

        var aToCenter = (a.BaseRadius * a.BaseRadius - b.BaseRadius * b.BaseRadius + dist * dist) / (2.0f * dist);
        var center = a.Center + aToCenter * Vector3.Normalize(d);
        var circleRadius = (float)Math.Sqrt(a.BaseRadius * a.BaseRadius - aToCenter * aToCenter);

        circle = new IntersectionCircle(center, circleRadius, Vector3.Normalize(d));
        return true;
    }

    // Placeholder for Perlin noise. In Unity, use Mathf.PerlinNoise.
    private float PerlinNoise(float x, float y, float z)
    {
        return 0.5f; // Placeholder
    }

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
        public float BaseRadius;
        public List<Vector3> SurfacePoints; // These points represent the warped surface
    }

    public struct IntersectionCircle
    {
        public Vector3 Center;
        public float Radius;
        public Vector3 Normal;

        public IntersectionCircle(Vector3 center, float radius, Vector3 normal)
        {
            Center = center;
            Radius = radius;
            Normal = normal;
        }
    }
}