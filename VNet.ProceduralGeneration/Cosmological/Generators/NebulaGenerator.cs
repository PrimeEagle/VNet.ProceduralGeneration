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

    protected override float CalculateAge(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }
}