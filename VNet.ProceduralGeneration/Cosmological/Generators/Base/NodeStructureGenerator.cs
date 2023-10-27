using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;
// ReSharper disable MemberCanBeProtected.Global

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class NodeStructureGenerator<T, TContext> : GroupGeneratorBase<T, TContext>
                                                            where T : NodeStructure, new()
                                                            where TContext : NodeStructureContext
{
    protected NodeStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }
}