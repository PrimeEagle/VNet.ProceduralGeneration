using Microsoft.Extensions.Logging;
using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;
using Void = VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base.Void;

// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable MemberCanBeMadeStatic.Local


namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class VoidGeneratorBase<T, TContext> : GroupGeneratorBase<T, TContext>, IDisposable
                                                        where T : Void, new()
                                                        where TContext : VoidContext
{
    protected VoidGeneratorBase(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<VoidGeneratorBase<T, TContext>> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override void GenerateWarpedSurface(TContext context, T self)
    {
        var radius = self.Diameter / 2;
        var pointsPerAxis = (int)(self.Diameter * context.SurfaceResolution);

        for (var i = 0; i < pointsPerAxis; i++)
            for (var j = 0; j < pointsPerAxis; j++)
                for (var k = 0; k < pointsPerAxis; k++)
                {
                    var point = new Vector3(
                                            i / context.SurfaceResolution,
                                            j / context.SurfaceResolution,
                                            k / context.SurfaceResolution
                                        ) - new Vector3(radius, radius, radius) + self.Position;

                    if (!((point - self.Position).Length() <= radius)) continue;

                    var coords = new double[] { point.X, point.Y, point.Z };
                    var warpAmount = (float)(context.SurfaceWarpingNoiseAlgorithm.GenerateSpatialSingleSample(coords) * context.SurfaceWarpingFactor);
                    var direction = Vector3.Normalize(point - self.Position);
                    var warpedPoint = point + Vector3.Multiply(warpAmount, direction);
                    if ((warpedPoint - self.Position).Length() <= radius) self.WarpedSurface.Add(warpedPoint);
                }
    }

    protected override void GenerateInteriorObjects(TContext context, T self)
    {
        var internalObjects = new List<IUndefinedAstronomicalObject>();
        var targetNumPoints = (int)((1 - context.InteriorSparsity) * context.InteriorMaxContents);

        while (internalObjects.Count < targetNumPoints)
        {
            var randomPoint = new Vector3(
                context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter,
                context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter,
                context.InteriorObjectRandomizationAlgorithm.NextSingle() * self.Diameter
            ) - new Vector3(CalculationService.CalculateRadius(self), CalculationService.CalculateRadius(self), CalculationService.CalculateRadius(self)) + self.Position;

            var randomObject = new UndefinedAstronomicalObject
            {
                Position = randomPoint
            };

            if (!((randomPoint - self.Position).Length() < CalculationService.CalculateRadius(self)) || PointsOverlap(internalObjects, randomObject)) continue;
            var newInteriorObject = new UndefinedAstronomicalObject
            {
                Position = randomPoint
            };

            internalObjects.Add(newInteriorObject);
        }

        self.InteriorObjects = internalObjects;
    }
}