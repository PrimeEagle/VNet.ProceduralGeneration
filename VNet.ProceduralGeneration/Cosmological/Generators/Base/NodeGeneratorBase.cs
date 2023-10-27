using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class NodeGeneratorBase<T, TContext> : GroupGeneratorBase<T, TContext>, IDisposable
    where T : Node, new()
    where TContext : NodeContext
{
    protected NodeGeneratorBase(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<NodeGeneratorBase<T, TContext>> loggerService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService)
    {
    }
}