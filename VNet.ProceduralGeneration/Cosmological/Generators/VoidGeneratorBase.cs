using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class VoidGeneratorBase<T, TContext> : ContainerGeneratorBase<T, TContext>, IDisposable
                                                           where T : AstronomicalObjectContainer, new()
                                                           where TContext : ContextBase
    {
        protected VoidGeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
        {
        }

        protected override void GenerateWarpedSurface(TContext context, T self)
        {
            base.GenerateWarpedSurface(context, self);

            var radius = self.Diameter / 2;
            var pointsPerAxis = (int)(self.Diameter * VoidSurfaceResolution);

            for (var i = 0; i < pointsPerAxis; i++)
            {
                for (var j = 0; j < pointsPerAxis; j++)
                {
                    for (var k = 0; k < pointsPerAxis; k++)
                    {
                        var point = new Vector3(
                            i / (float)VoidSurfaceResolution,
                            j / (float)VoidSurfaceResolution,
                            k / (float)VoidSurfaceResolution
                        ) - new Vector3(radius, radius, radius) + self.Position;

                        if (!((point - self.Position).Length() <= radius)) continue;

                        float warpAmount = context.SurfaceNoiseAlgorithm.GenerateSpatialSingleSample(point) * VoidSurfaceWarpingFactor;
                        var direction = Vector3.Normalize(point - self.Position);
                        var warpedPoint = point + direction * warpAmount;
                        if ((warpedPoint - self.Position).Length() <= radius)
                        {
                            self.WarpedSurface.Add(warpedPoint);
                        }
                    }
                }
            }
        }

        protected override void GenerateInterior(TContext context, T self)
        {
            base.GenerateInterior(context, self);

            var internalPoints = new List<Vector3>();
            var targetNumPoints = (int)((1 - VoidInteriorSparsity) * VoidInteriorMaxContents);

            while (internalPoints.Count < targetNumPoints)
            {
                var randomPoint = new Vector3(
                    context.InteriorRandomizationAlgorithm.NextSingle() * self.Diameter,
                    context.InteriorRandomizationAlgorithm.NextSingle() * self.Diameter,
                    context.InteriorRandomizationAlgorithm.NextSingle() * self.Diameter
                ) - new Vector3(self.Radius, self.Radius, self.Radius) + self.Position;

                if ((randomPoint - self.Position).Length() < self.Radius && !PointOverlap(internalPoints, randomPoint))
                {
                    internalPoints.Add(randomPoint);
                }
            }

            self.Interior = internalPoints;
        }

        private bool PointOverlap(IEnumerable<Vector3> points, Vector3 newPoint)
        {
            return points.Any(point => Vector3.Distance(point, newPoint) < 0.01f);
        }

        protected override void GenerateBoundingBox(TContext context, T self)
        {
            self.BoundingBox = new BoundingBox<float>(self.Position, 1, new Vector3(0, 0, 1) * self.Diameter);
        }
    }
}