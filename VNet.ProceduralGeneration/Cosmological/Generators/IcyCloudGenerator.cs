using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IcyCloudGenerator : BaseGenerator<IcyCloud, IcyCloudContext>
{
    public IcyCloudGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<IcyCloud> GenerateSelf(IcyCloudContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(IcyCloud self, IcyCloudContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(IcyCloud self, IcyCloudContext context)
    {
        throw new NotImplementedException();
    }
}