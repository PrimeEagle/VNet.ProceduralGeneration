using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public abstract class BaseGenerator<T, TContext> : IGeneratable<T, TContext>, IDisposable 
                                                                                 where T : AstronomicalObject
                                                                                 where TContext : BaseContext
    {
        private bool _disposed = false;

        protected readonly GeneratorSettings Settings;
        protected readonly BasicGenerationSettings BasicSettings;
        protected readonly AdvancedGenerationSettings AdvancedSettings;
        protected readonly AstronomicalObjectToggleSettings ObjectToggles;
        protected readonly TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles;
        private ParallelismLevel _parallelismLevel;
        private readonly SemaphoreSlim _semaphore;


        protected BaseGenerator(ParallelismLevel parallelismLevel)
        {
            this.Settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
            this.BasicSettings = Settings.Basic;
            this.AdvancedSettings = Settings.Advanced;
            this.ObjectToggles = Settings.ObjectToggles;
            this.TheoreticalObjectToggles = Settings.TheoreticalObjectToggles;
            this._parallelismLevel = parallelismLevel;
            _semaphore = new SemaphoreSlim(GetDegreesOfParallelism());
        }

        protected async Task<T> ExecuteWithConcurrencyControlAsync<T>(Func<Task<T>> taskFactory)
        {
            await _semaphore.WaitAsync();
            try
            {
                return await taskFactory();
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private int GetDegreesOfParallelism()
        {
            var calculated = 1;
            var configured = 1;

            switch(_parallelismLevel)
            {
                case ParallelismLevel.Level0:
                    calculated = 1;
                    configured = 1;
                    break;
                case ParallelismLevel.Level1:
                    calculated = Environment.ProcessorCount;
                    configured = AdvancedSettings.MaxDegreesOfParallelismLevel1;
                    break;
                case ParallelismLevel.Level2:
                    calculated = Convert.ToInt32(0.75 * Environment.ProcessorCount);
                    configured = AdvancedSettings.MaxDegreesOfParallelismLevel2;
                    break;
                case ParallelismLevel.Level3:
                    calculated = Convert.ToInt32(0.5 * Environment.ProcessorCount);
                    configured = AdvancedSettings.MaxDegreesOfParallelismLevel3;
                    break;
                case ParallelismLevel.Level4:
                    calculated = Convert.ToInt32(0.25 * Environment.ProcessorCount);
                    configured = AdvancedSettings.MaxDegreesOfParallelismLevel4;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return configured < calculated ? configured : calculated;
        }

        public abstract Task<T> Generate(TContext context);

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