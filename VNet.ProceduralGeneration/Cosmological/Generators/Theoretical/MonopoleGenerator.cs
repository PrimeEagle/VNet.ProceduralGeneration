using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MonopoleGenerator : GeneratorBase<Monopole, MonopoleContext>
{
    public MonopoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Monopole> GenerateSelf(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }
}