using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaGenerator : GeneratorBase<Supernova, SupernovaContext>
{
    public SupernovaGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Supernova> GenerateSelf(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }
}