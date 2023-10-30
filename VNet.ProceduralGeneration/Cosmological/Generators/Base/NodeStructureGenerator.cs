using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;
// ReSharper disable MemberCanBeProtected.Global

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class NodeStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : NodeStructure, new()
                                                            where TContext : NodeStructureContext
{
    protected NodeStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<NodeStructureGenerator<T, TContext>> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }
}