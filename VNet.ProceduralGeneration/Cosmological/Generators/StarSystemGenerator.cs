using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : ContainerGeneratorBase<StarSystem, StarSystemContext>
{
    public StarSystemGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<StarSystem> GenerateSelf(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }
}