using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NeutronStarGenerator : GeneratorBase<NeutronStar, NeutronStarContext>
{
    public NeutronStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<NeutronStar> GenerateSelf(NeutronStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NeutronStar self, NeutronStarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(NeutronStar self, NeutronStarContext context)
    {
        throw new NotImplementedException();
    }
}