namespace VNet.ProceduralGeneration.Cosmological;

public class IcyCloudGenerator : IGeneratable<IcyCloud, IcyCloudContext>
{
    public IcyCloud Generate(IcyCloudContext context)
    {
        var icyCloud = new IcyCloud
        {
            // ... Generate properties specific to IcyCloud
        };
        return icyCloud;
    }
}