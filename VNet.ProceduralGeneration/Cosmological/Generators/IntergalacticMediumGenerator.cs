using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IntergalacticMediumGenerator : GeneratorBase<IntergalacticMedium, IntergalacticMediumContext>
{
    public IntergalacticMediumGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override Task<IntergalacticMedium> GenerateSelf(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(IntergalacticMediumContext context, IntergalacticMedium self)
    {
        throw new NotImplementedException();
    }
}