using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;
// ReSharper disable MemberCanBeProtected.Global

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class SheetStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : SheetStructure, new()
                                                            where TContext : SheetStructureContext
{
    protected SheetStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }
}