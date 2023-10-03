using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentGenerator : GeneratorBase<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{
    public BaryonicMatterFilamentGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterFilament> GenerateSelf(BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterFilament self, BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterFilament self, BaryonicMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }
}