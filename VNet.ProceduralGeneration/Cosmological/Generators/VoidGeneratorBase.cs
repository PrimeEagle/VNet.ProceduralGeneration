using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;


// ReSharper disable MemberCanBeMadeStatic.Local


namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class VoidGeneratorBase<T, TContext> : ContainerGeneratorBase<T, TContext>, IDisposable
                                                           where T : global::VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Void, new()
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

            var internalObjects = new List<IUndefinedAstronomicalObject>();
            var targetNumPoints = (int)((1 - context.InteriorSparsity) * context.InteriorMaxContents);

            while (internalObjects.Count < targetNumPoints)
            {
                var randomPoint = new Vector3(
                    context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter,
                    context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter,
                    context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter
                ) - new Vector3(self.Radius, self.Radius, self.Radius) + self.Position;

                var randomObject = new UndefinedAstronomicalObject()
                {
                    Position = randomPoint
                };

                if (!((randomPoint - self.Position).Length() < self.Radius) || PointsOverlap(internalObjects, randomObject)) continue;
                var newInteriorObject = new UndefinedAstronomicalObject()
                {
                    Position = randomPoint
                };

                internalObjects.Add(newInteriorObject);
            }

            self.InteriorObjects = internalObjects;
        }

        protected override void GenerateBoundingBox(TContext context, T self)
        {
            self.BoundingBox = new BoundingBox<float>(self.Position, 1, Vector3.UnitZ * self.Diameter);
        }
    }
}