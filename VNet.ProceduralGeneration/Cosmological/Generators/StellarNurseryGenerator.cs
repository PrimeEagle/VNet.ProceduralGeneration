using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StellarNurseryGenerator : GeneratorBase<StellarNursery, StellarNurseryContext>
{
    public StellarNurseryGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float GenerateAge(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }
}