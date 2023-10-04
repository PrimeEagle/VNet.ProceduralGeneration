using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : GeneratorBase<Nova, NovaContext>
{
    public NovaGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Nova> GenerateSelf(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }
}