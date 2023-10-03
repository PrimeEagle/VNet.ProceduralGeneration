using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MonopoleGenerator : GeneratorBase<Monopole, MonopoleContext>
{
    public MonopoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Monopole> GenerateSelf(MonopoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Monopole self, MonopoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Monopole self, MonopoleContext context)
    {
        throw new NotImplementedException();
    }
}