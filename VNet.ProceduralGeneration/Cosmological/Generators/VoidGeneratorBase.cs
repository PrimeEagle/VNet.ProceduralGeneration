using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;
using Void = VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Void;

// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class VoidGeneratorBase<T, TContext> : ContainerGeneratorBase<T, TContext>, IDisposable
                                                           where T : Void, new()
                                                           where TContext : VoidContext
    {
        protected VoidGeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
        {
        }

        protected override void GenerateWarpedSurface(TContext context, T self)
        {
            base.GenerateWarpedSurface(context, self);

            var radius = self.Diameter / 2;
            var pointsPerAxis = (int)(self.Diameter * context.SurfaceResolution);

            for (var i = 0; i < pointsPerAxis; i++)
            {
                for (var j = 0; j < pointsPerAxis; j++)
                {
                    for (var k = 0; k < pointsPerAxis; k++)
                    {
                        var point = new Vector3(
                            i / (float)context.SurfaceResolution,
                            j / (float)context.SurfaceResolution,
                            k / (float)context.SurfaceResolution
                        ) - new Vector3(radius, radius, radius) + self.Position;

                        if (!((point - self.Position).Length() <= radius)) continue;

                        var coords = new double[] { point.X, point.Y, point.Z };
                        var warpAmount = (float)(context.SurfaceWarpingNoiseAlgorithm.GenerateSpatialSingleSample(coords) * context.SurfaceWarpingFactor);
                        var direction = Vector3.Normalize(point - self.Position);
                        var warpedPoint = point + Vector3.Multiply(warpAmount, direction);
                        if ((warpedPoint - self.Position).Length() <= radius)
                        {
                            self.WarpedSurface.Add(warpedPoint);
                        }
                    }
                }
            }
        }

        protected override void GenerateInteriorObjects(TContext context, T self)
        {
            base.GenerateInteriorObjects(context, self);

            var internalPoints = new List<IUndefinedAstronomicalObject>();
            var targetNumPoints = (int)((1 - context.InteriorSparsity) * context.InteriorMaxContents);

            while (internalPoints.Count < targetNumPoints)
            {
                var randomPoint = new Vector3(
                    context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter,
                    context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter,
                    context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter
                ) - new Vector3(self.Radius, self.Radius, self.Radius) + self.Position;

                if (!((randomPoint - self.Position).Length() < self.Radius) || PointOverlap(internalPoints, randomPoint)) continue;
                var newInteriorObject = new UndefinedAstronomicalObject()
                {
                    Position = randomPoint
                };

                internalPoints.Add(newInteriorObject);
            }

            self.InteriorObjects = internalPoints;
        }

        private bool PointOverlap(IEnumerable<IUndefinedAstronomicalObject> points, Vector3 newPoint)
        {
            return points.Any(i => Vector3.Distance(i.Position, newPoint) < 0.01f);
        }

        protected override void GenerateBoundingBox(TContext context, T self)
        {
            self.BoundingBox = new BoundingBox<float>(self.Position, 1, Vector3.UnitZ * self.Diameter);
        }
    }
}