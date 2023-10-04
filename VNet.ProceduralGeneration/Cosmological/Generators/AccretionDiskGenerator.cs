using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AccretionDiskGenerator : GeneratorBase<AccretionDisk, AccretionDiskContext>
{
    protected override Task<AccretionDisk> GenerateSelf(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    public AccretionDiskGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }
}