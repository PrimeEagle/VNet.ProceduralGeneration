using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTornadoGenerator : GeneratorBase<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicTornado> GenerateSelf(CosmicTornadoContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicTornado self, CosmicTornadoContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicTornado self, CosmicTornadoContext context)
    {
        throw new NotImplementedException();
    }
}