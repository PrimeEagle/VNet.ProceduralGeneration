using System.Reflection.Emit;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class GeneratorBase<T, TContext>        : IGeneratable<T, TContext>, IDisposable 
                                             where T        : AstronomicalObject, new()
                                             where TContext : BaseContext
    {
        private bool _disposed = false;

        protected bool enabled;
        protected readonly GeneratorSettings Settings;
        protected readonly BasicGenerationSettings BasicSettings;
        protected readonly AdvancedGenerationSettings AdvancedSettings;
        protected readonly AstronomicalObjectToggleSettings ObjectToggles;
        protected readonly TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles;
        protected readonly EventAggregator eventAggregator;
        private readonly ParallelismLevel _parallelismLevel;
        private readonly SemaphoreSlim _semaphore;



        protected GeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel)
        {
            this.Settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
            this.BasicSettings = Settings.Basic;
            this.AdvancedSettings = Settings.Advanced;
            this.ObjectToggles = Settings.ObjectToggles;
            this.TheoreticalObjectToggles = Settings.TheoreticalObjectToggles;
            this._parallelismLevel = parallelismLevel;
            this.eventAggregator = eventAggregator;
            _semaphore = new SemaphoreSlim(GetDegreesOfParallelism());
        }

        protected async Task<T> ExecuteWithConcurrencyControlAsync<T>(Func<Task<T>> taskFactory)
        {
            await _semaphore.WaitAsync();
            try
            {
                return await Task.Run(taskFactory);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private int GetDegreesOfParallelism()
        {
            var parallelismMap = new Dictionary<ParallelismLevel, (int calculated, int configured)>
            {
                [ParallelismLevel.Level0] = (1, 1),
                [ParallelismLevel.Level1] = (Environment.ProcessorCount, AdvancedSettings.Application.MaxDegreesOfParallelismLevel1),
                [ParallelismLevel.Level2] = (Convert.ToInt32(0.75 * Environment.ProcessorCount), AdvancedSettings.Application.MaxDegreesOfParallelismLevel2),
                [ParallelismLevel.Level3] = (Convert.ToInt32(0.5 * Environment.ProcessorCount), AdvancedSettings.Application.MaxDegreesOfParallelismLevel3),
                [ParallelismLevel.Level4] = (Convert.ToInt32(0.25 * Environment.ProcessorCount), AdvancedSettings.Application.MaxDegreesOfParallelismLevel4)
            };

            if (!parallelismMap.TryGetValue(_parallelismLevel, out var values))
            {
                throw new ArgumentOutOfRangeException();
            }

            return Math.Min(values.calculated, values.configured);
        }

        protected abstract Task<T> GenerateSelf(TContext context);
        protected abstract Task GenerateChildren(T self, TContext context);
        protected abstract Task PostProcess(T self, TContext context);

        public async Task<T> Generate(TContext context, AstronomicalObject parent)
        {
            T self;

            if (enabled)
            {
                Events.EventBuilder.CreateGeneratingEvent(this.eventAggregator, nameof(T), null);
                self = await ExecuteWithConcurrencyControlAsync(() => GenerateSelf(context));
                Events.EventBuilder.CreateGeneratedEvent(this.eventAggregator, nameof(T), self);
            }
            else
            {
                self = new T();
            }

            self.Parent = parent;

            await GenerateChildren(self, context);

            if (!enabled) return self;

            Events.EventBuilder.CreatePostProcessingEvent(this.eventAggregator, nameof(T), self);
            await PostProcess(self, context);
            Events.EventBuilder.CreatePostProcessedEvent(this.eventAggregator, nameof(T), self);

            return self;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _semaphore?.Dispose();
            }

            _disposed = true;
        }
    }
}