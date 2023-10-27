using Microsoft.Extensions.DependencyInjection;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Services
{
    public class GeneratorFactoryService : IGeneratorFactoryService
    {
        private readonly IServiceProvider _serviceProvider;

        public GeneratorFactoryService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IGenerator<T, TContext> Create<T, TContext>()
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            return _serviceProvider.GetRequiredService<IGenerator<T, TContext>>();
        }
    }
}