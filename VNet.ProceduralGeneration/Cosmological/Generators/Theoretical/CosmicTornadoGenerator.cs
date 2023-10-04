using System.Numerics;
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

    protected override Task<CosmicTornado> GenerateSelf(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(CosmicTornadoContext context, CosmicTornado self)
    {
        throw new NotImplementedException();
    }
}