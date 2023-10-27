using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentGenerator : FilamentGeneratorBase<DarkMatterFilament, DarkMatterFilamentContext>
{
    public DarkMatterFilamentGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<DarkMatterFilamentGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterFilament> GenerateSelf(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }
}