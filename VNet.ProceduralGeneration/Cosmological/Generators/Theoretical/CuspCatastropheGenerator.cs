using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CuspCatastropheGenerator : GeneratorBase<CuspCatastrophe, CuspCatastropheContext>
{
    public CuspCatastropheGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CuspCatastrophe> GenerateSelf(CuspCatastropheContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CuspCatastrophe self, CuspCatastropheContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CuspCatastrophe self, CuspCatastropheContext context)
    {
        throw new NotImplementedException();
    }
}