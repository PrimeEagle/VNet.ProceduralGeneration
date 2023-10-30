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

        public T Generate<T, TContext>(TContext context, AstronomicalObject parent)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            return GenerateAsync<T, TContext>(context, parent).GetAwaiter().GetResult();
        }

        public void GenerateDiameter<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GenerateDiameterAsync(context, self).GetAwaiter().GetResult();
        }

        public void GeneratePosition<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GeneratePositionAsync(context, self).GetAwaiter().GetResult();
        }

        public void GenerateOrientation<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GenerateOrientationAsync(context, self).GetAwaiter().GetResult();
        }

        public void GenerateAge<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GenerateAgeAsync(context, self).GetAwaiter().GetResult();
        }

        public void GenerateLifespan<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {

        }

        public void GenerateMass<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GenerateMassAsync(context, self).GetAwaiter().GetResult();
        }

        public void GenerateLuminosity<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GenerateLuminosityAsync(context, self).GetAwaiter().GetResult();
        }
        public void GenerateTemperature<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            GenerateTemperatureAsync(context, self).GetAwaiter().GetResult();
        }

        public async Task<T> GenerateAsync<T, TContext>(TContext context, AstronomicalObject parent)
                                            where T : AstronomicalObject
                                            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();

            return await generator.GenerateAsync(context, parent);
        }

        public async Task GenerateDiameterAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateDiameterAsync(context, self);
        }

        public async Task GeneratePositionAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GeneratePositionAsync(context, self);
        }

        public async Task GenerateOrientationAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateOrientationAsync(context, self);
        }
        public async Task GenerateAgeAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateAgeAsync(context, self);
        }

        public async Task GenerateLifespanAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateLifespanAsync(context, self);
        }

        public async Task GenerateMassAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateMassAsync(context, self);
        }
        public async Task GenerateLuminosityAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateLuminosityAsync(context, self);
        }

        public async Task GenerateTemperatureAsync<T, TContext>(TContext context, T self)
            where T : AstronomicalObject
            where TContext : ContextBase
        {
            var generator = await _generatorFactoryService.CreateAsync<T, TContext>();
            await generator.GenerateTemperatureAsync(context, self);
        }
    }
}