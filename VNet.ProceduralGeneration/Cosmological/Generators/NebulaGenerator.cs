using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NebulaGenerator : GeneratorBase<Nebula, NebulaContext>
{
    public NebulaGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(NebulaContext context, Nebula self)
    {
        throw new NotImplementedException();
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
}