using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : GeneratorBase<AsteroidBelt, AsteroidBeltContext>
{
    protected override Task<AsteroidBelt> GenerateSelf(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    public AsteroidBeltGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }
}