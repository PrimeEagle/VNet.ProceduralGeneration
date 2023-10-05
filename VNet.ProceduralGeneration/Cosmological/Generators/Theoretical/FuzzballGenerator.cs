using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FuzzballGenerator : GeneratorBase<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Fuzzball> GenerateSelf(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }
}