using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentGenerator : FilamentGeneratorBase<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{
    public BaryonicMatterFilamentGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BaryonicMatterFilament> GenerateSelf(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }
}