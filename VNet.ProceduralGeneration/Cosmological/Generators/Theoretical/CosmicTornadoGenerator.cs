using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTornadoGenerator : GeneratorBase<CosmicTornado, CosmicTornadoContext>
{
    public CosmicTornadoGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
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
}