using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicStringGenerator : GeneratorBase<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicString> GenerateSelf(CosmicStringContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicString self, CosmicStringContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicString self, CosmicStringContext context)
    {
        throw new NotImplementedException();
    }
}