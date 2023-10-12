using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : GeneratorBase<Nova, NovaContext>
{
    public NovaGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Nova> GenerateSelf(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }
}