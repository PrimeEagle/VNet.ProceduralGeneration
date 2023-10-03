using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : GeneratorBase<StarSystem, StarSystemContext>
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

    protected override float CalculateAge(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }
}