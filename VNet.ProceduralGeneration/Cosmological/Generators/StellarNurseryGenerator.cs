using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StellarNurseryGenerator : GeneratorBase<StellarNursery, StellarNurseryContext>
{
    public StellarNurseryGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StellarNursery> GenerateSelf(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }
}