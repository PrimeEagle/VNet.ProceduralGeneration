using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class WhiteHoleGenerator : GeneratorBase<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<WhiteHole> GenerateSelf(WhiteHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(WhiteHole self, WhiteHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(WhiteHole self, WhiteHoleContext context)
    {
        throw new NotImplementedException();
    }
}