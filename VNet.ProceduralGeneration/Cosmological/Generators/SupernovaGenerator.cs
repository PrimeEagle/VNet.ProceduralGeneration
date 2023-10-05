using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaGenerator : GeneratorBase<Supernova, SupernovaContext>
{
    public SupernovaGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Supernova> GenerateSelf(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }
}