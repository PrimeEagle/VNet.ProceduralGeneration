using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NebulaGenerator : GeneratorBase<Nebula, NebulaContext>
{
    public NebulaGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Nebula> GenerateSelf(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }
}