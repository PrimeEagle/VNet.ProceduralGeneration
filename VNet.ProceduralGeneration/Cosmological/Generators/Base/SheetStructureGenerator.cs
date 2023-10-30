using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

// ReSharper disable MemberCanBeProtected.Global

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class SheetStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : SheetStructure, new()
                                                            where TContext : SheetStructureContext
{
    protected SheetStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<SheetStructureGenerator<T, TContext>> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }
}