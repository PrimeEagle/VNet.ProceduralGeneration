using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StellarNurseryGenerator : GeneratorBase<StellarNursery, StellarNurseryContext>
{
    public StellarNurseryGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StellarNursery> GenerateSelf(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }
}