using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Services
{
    public class GeneratorInvokerService
    {
        private readonly IGeneratorFactoryService _generatorFactoryService;


        public GeneratorInvokerService(IGeneratorFactoryService generatorFactoryService)
        {
            _generatorFactoryService = generatorFactoryService;
        }

        public async Task<T> Generate<T, TContext>(TContext context, AstronomicalObject parent)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();

            return await generator.Generate(context, parent);
        }
    }
}