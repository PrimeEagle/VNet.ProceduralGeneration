using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : GeneratorBase<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterVoid self, BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterVoid self, BaryonicMatterVoidContext context)
    {
        throw new NotImplementedException();
    }
}