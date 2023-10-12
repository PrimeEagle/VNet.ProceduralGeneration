using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : GeneratorBase<Moon, MoonContext>
{
    public MoonGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Moon> GenerateSelf(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }
}