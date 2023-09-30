using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AccretionDiskGenerator : BaseGenerator<AccretionDisk, AccretionDiskContext>
{
    public override async Task<AccretionDisk> Generate(AccretionDiskContext context)
    {
        var disk = new AccretionDisk
        {

        };

        return disk;
    }

    public AccretionDiskGenerator() : base(ParallelismLevel.Level4)
    {
    }
}