using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class SheetGeneratorBase<T, TContext> : GroupGeneratorBase<T, TContext>, IDisposable
    where T : Sheet, new()
    where TContext : SheetContext
{
    protected SheetGeneratorBase(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<SheetGeneratorBase<T, TContext>> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }
}