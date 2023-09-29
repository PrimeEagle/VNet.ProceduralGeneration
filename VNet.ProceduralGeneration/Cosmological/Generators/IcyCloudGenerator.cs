using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class IcyCloudGenerator : BaseGenerator<IcyCloud, IcyCloudContext>
{
    public override IcyCloud Generate(IcyCloudContext context)
    {
        var icyCloud = new IcyCloud
        {

        };

        return icyCloud;
    }

    public IcyCloudGenerator(GeneratorConfig config) : base(config)
    {
    }
}