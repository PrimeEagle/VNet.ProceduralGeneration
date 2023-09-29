using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class AccretionDiskGenerator : BaseGenerator<AccretionDisk, AccretionDiskContext>
{
    public override AccretionDisk Generate(AccretionDiskContext context)
    {
        var disk = new AccretionDisk
        {

        };

        return disk;
    }

    public AccretionDiskGenerator(GeneratorConfig config) : base(config)
    {
    }
}