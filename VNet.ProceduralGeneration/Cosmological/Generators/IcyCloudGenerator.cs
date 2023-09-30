using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IcyCloudGenerator : BaseGenerator<IcyCloud, IcyCloudContext>
{
    public override async Task<IcyCloud> Generate(IcyCloudContext context)
    {
        var icyCloud = new IcyCloud
        {

        };

        return icyCloud;
    }

    public IcyCloudGenerator() : base(ParallelismLevel.Level4)
    {
    }
}