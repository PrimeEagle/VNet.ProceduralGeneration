using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ExocometaryCloudGenerator : GroupGeneratorBase<ExocometaryCloud, ExocometaryCloudContext>
{
    public ExocometaryCloudGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<ExocometaryCloudGenerator> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }

    protected override Task GenerateChildren(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task<ExocometaryCloud> GenerateSelf(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }
}