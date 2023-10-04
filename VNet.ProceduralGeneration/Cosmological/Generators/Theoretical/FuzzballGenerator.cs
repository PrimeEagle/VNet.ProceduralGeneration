using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FuzzballGenerator : GeneratorBase<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float GenerateAge(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }
}