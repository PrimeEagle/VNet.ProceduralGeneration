using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : GeneratorBase<SupernovaRemnant, SupernovaRemnantContext>
{
    public SupernovaRemnantGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override Task<SupernovaRemnant> GenerateSelf(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }
}