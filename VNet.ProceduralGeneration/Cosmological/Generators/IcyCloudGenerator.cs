using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IcyCloudGenerator : GeneratorBase<IcyCloud, IcyCloudContext>
{
    public IcyCloudGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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

    protected override Task PostProcess(IcyCloud self, IcyCloudContext context)
    {
        throw new NotImplementedException();
    }
}