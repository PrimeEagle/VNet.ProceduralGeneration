using Microsoft.Extensions.Logging;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

// ReSharper disable NotAccessedField.Local
#pragma warning disable IDE0052


namespace VNet.ProceduralGeneration.Cosmological.Generators.Services
{
    public class GeneratorInvokerService : IGeneratorInvokerService
    {
        private readonly IGeneratorFactoryService _generatorFactoryService;
        private readonly ILogger<GeneratorInvokerService> _loggerService;


        public GeneratorInvokerService(IGeneratorFactoryService generatorFactoryService, ILogger<GeneratorInvokerService> logger)
        {
            _generatorFactoryService = generatorFactoryService;
            _loggerService = logger;
        }

        public async Task<T> Generate<T, TContext>(TContext context, AstronomicalObject parent)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();

            return await generator.Generate(context, parent);
        }

        public void GenerateDiameter<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateDiameter(context, self);
        }
        public void GeneratePosition<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GeneratePosition(context, self);
        }
        public void GenerateOrientation<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateOrientation(context, self);
        }
        public void GenerateAge<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateAge(context, self);
        }
        public void GenerateLifespan<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateDiameter(context, self);
        }
        public void GenerateMass<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateMass(context, self);
        }
        public void GenerateLuminosity<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateLuminosity(context, self);
        }
        public void GenerateTemperature<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = _generatorFactoryService.Create<T, TContext>();
            generator.GenerateTemperature(context, self);
        }
    }
}