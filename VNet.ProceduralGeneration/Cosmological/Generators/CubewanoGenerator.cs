using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CubewanoGenerator : GeneratorBase<Cubewano, CubewanoContext>
{
    protected override void GenerateAge(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateDiameter(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Cubewano> GenerateSelf(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    public CubewanoGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }
}