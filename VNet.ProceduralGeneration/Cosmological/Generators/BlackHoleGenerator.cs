using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : GeneratorBase<BlackHole, BlackHoleContext>
{
    public BlackHoleGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<BlackHole> GenerateSelf(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }
}