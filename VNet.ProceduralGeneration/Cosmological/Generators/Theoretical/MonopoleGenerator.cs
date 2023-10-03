using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MonopoleGenerator : GeneratorBase<Monopole, MonopoleContext>
{
    public MonopoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Monopole> GenerateSelf(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }
}