using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AccretionDiskGenerator : GeneratorBase<AccretionDisk, AccretionDiskContext>
{
    public AccretionDiskGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
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

    public override void GenerateRandomGenerationAlgorithm(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(AccretionDiskContext context, AccretionDisk self)
    {
        throw new NotImplementedException();
    }
}