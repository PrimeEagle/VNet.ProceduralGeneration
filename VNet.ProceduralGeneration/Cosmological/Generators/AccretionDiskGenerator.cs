using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AccretionDiskGenerator : GeneratorBase<AccretionDisk, AccretionDiskContext>
{
    public AccretionDiskGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task<AccretionDisk> GenerateSelf(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }
}