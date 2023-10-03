using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CometGenerator : GeneratorBase<Comet, CometContext>
{
    public CometGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Comet> GenerateSelf(CometContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Comet self, CometContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Comet self, CometContext context)
    {
        throw new NotImplementedException();
    }
}