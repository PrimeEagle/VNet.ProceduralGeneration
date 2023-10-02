using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTornadoGenerator : BaseGenerator<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator() : base(ParallelismLevel.Level4)
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