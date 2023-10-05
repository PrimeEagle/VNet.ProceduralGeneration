using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentGenerator : ContainerGeneratorBase<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{
    public BaryonicMatterFilamentGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterFilament> GenerateSelf(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }
}