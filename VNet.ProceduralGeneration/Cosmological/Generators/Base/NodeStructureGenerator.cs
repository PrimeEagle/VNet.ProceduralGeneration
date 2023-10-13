using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;
// ReSharper disable MemberCanBeProtected.Global

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class NodeStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : NodeStructure, new()
                                                            where TContext : NodeStructureContext
{
    protected NodeStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }
}