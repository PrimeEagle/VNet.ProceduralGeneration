using System.Numerics;
using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;
using Void = VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base.Void;

// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable UnusedMember.Local
// ReSharper disable ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
// ReSharper disable LoopCanBeConvertedToQuery


namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class VoidStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : VoidStructure, new()
                                                            where TContext : VoidStructureContext
{
    protected VoidStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<VoidStructureGenerator<T, TContext>> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected float CalculateOverlapAmount(Void voidItem, IEnumerable<IVoid> existingVoids)
    {
        float overlapAmount = 0;

        foreach (var existingVoid in existingVoids)
        {
            var distanceBetweenCenters = Vector3.Distance(voidItem.Position, existingVoid.Position);
            var combinedRadii = CalculationService.CalculateRadius(voidItem) + CalculationService.CalculateRadius(existingVoid);

            if (distanceBetweenCenters < combinedRadii) overlapAmount += combinedRadii - distanceBetweenCenters;
        }

        return overlapAmount;
    }
}