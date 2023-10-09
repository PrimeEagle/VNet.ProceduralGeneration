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
                                             where TContext : ContextBase
    {
        private bool _disposed = false;
        private readonly ParallelismLevel _parallelismLevel;
        private readonly SemaphoreSlim _semaphore;


        protected bool Enabled;
        protected TContext Context;
        protected readonly GeneratorSettings Settings;
        protected readonly BasicGenerationSettings BasicSettings;
        protected readonly AdvancedGenerationSettings AdvancedSettings;
        protected readonly AstronomicalObjectToggleSettings ObjectToggles;
        protected readonly TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles;
        protected readonly EventAggregator EventAggregator;
        protected abstract void GenerateDiameter(TContext context, T self);
        protected abstract void GeneratePosition(TContext context, T self);
        protected abstract void GenerateAge(TContext context, T self);
        protected abstract void GenerateLifespan(TContext context, T self);
        protected abstract void GenerateMass(TContext context, T self);
        protected abstract void GenerateLuminosity(TContext context, T self);
        protected abstract void GenerateTemperature(TContext context, T self);
        protected abstract Task<T> GenerateSelf(TContext context, T self);
        protected abstract Task GenerateChildren(TContext context, T self);
        protected abstract Task PostProcess(TContext context, T self);

        protected GeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel)
        {
            this.Settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
            this.BasicSettings = Settings.Basic;
            this.AdvancedSettings = Settings.Advanced;
            this.ObjectToggles = Settings.ObjectToggles;
            this.TheoreticalObjectToggles = Settings.TheoreticalObjectToggles;
            this._parallelismLevel = parallelismLevel;
            this.EventAggregator = eventAggregator;
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

        public async Task<T> Generate(TContext context, AstronomicalObject parent)
        {
            T self;
            this.Context = context;

            if (Enabled)
            {
                Events.EventBuilder.CreateGeneratingEvent(this.EventAggregator, nameof(T), null);
                self = new T
                {
                    Parent = parent,
                    Enabled = true
                };
                self = await ExecuteWithConcurrencyControlAsync(() => GenerateSelf(context, self));
            }
            else
            {
                self = new T();
            }

            self.Parent = parent;
            if (!parent.Enabled)
            {
                self.Universe.NonHierarchyObjects.Add(self);
            }

            await GenerateChildren(context, self);
            
            if (!Enabled) return self;
            GenerateBaseProperties(context, self);
            self.AssignChildren();
            Events.EventBuilder.CreateGeneratedEvent(this.EventAggregator, nameof(T), self);

            Events.EventBuilder.CreatePostProcessingEvent(this.EventAggregator, nameof(T), self);
            await PostProcess(context, self);
            Events.EventBuilder.CreatePostProcessedEvent(this.EventAggregator, nameof(T), self);

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

        protected virtual void GenerateBaseProperties(TContext context, T self)
        {
            GenerateDiameter(context, self);
            GeneratePosition(context, self);
            GenerateAge(context, self);
            GenerateLifespan(context, self);
            GenerateMass(context, self);
            GenerateLuminosity(context, self);
            GenerateTemperature(context, self);
        }
    }
}