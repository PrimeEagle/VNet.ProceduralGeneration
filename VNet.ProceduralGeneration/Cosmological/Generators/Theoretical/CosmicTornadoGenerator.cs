using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTornadoGenerator : GeneratorBase<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<CosmicTornado> GenerateSelf(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }
}