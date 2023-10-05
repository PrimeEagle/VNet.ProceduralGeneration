using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : ContainerGeneratorBase<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }
}