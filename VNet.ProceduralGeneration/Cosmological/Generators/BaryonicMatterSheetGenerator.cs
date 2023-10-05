using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : ContainerGeneratorBase<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterSheet> GenerateSelf(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }
}