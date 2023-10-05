using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : GeneratorBase<BlackHole, BlackHoleContext>
{
    public BlackHoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BlackHole> GenerateSelf(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }
}