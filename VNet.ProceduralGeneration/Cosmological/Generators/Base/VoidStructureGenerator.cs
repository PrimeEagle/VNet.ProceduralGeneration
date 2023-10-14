using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;
using Void = VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base.Void;
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable SuggestBaseTypeForParameter
// ReSharper disable UnusedMember.Local
// ReSharper disable ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator
#pragma warning disable IDE0051
#pragma warning disable CA1822

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class VoidStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : VoidStructure, new()
                                                            where TContext : VoidStructureContext
{
    protected VoidStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    private float CalculateOverlapAmount(Void voidItem, List<Void> existingVoids)
    {
        float overlapAmount = 0;

        foreach (var existingVoid in existingVoids)
        {
            var distanceBetweenCenters = Vector3.Distance(voidItem.Position, existingVoid.Position);
            var combinedRadii = voidItem.Radius + existingVoid.Radius;

            if (distanceBetweenCenters < combinedRadii) overlapAmount += combinedRadii - distanceBetweenCenters;
        }

        return overlapAmount;
    }
}