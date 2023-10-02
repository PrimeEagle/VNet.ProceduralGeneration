using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AccretionDiskGenerator : BaseGenerator<AccretionDisk, AccretionDiskContext>
{
    protected override Task<AccretionDisk> GenerateSelf(AccretionDiskContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AccretionDisk self, AccretionDiskContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(AccretionDisk self, AccretionDiskContext context)
    {
        throw new NotImplementedException();
    }

    public AccretionDiskGenerator() : base(ParallelismLevel.Level4)
    {
    }
}