using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;

// ReSharper disable NotAccessedField.Local
#pragma warning disable IDE0052


namespace VNet.ProceduralGeneration.Cosmological.Generators.Services
{
    public class GeneratorFactoryService : IGeneratorFactoryService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<GeneratorFactoryService> _loggerService;


        public GeneratorFactoryService(IServiceProvider serviceProvider, ILogger<GeneratorFactoryService> logger)
        {
            _serviceProvider = serviceProvider;
            _loggerService = logger;
        }

        public IGenerator<T, TContext> Create<T, TContext>()
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            return _serviceProvider.GetRequiredService<IGenerator<T, TContext>>();
        }
    }
}