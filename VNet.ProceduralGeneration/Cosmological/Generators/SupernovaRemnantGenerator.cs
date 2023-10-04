using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : GeneratorBase<SupernovaRemnant, SupernovaRemnantContext>
{
    public SupernovaRemnantGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float GenerateAge(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }
}