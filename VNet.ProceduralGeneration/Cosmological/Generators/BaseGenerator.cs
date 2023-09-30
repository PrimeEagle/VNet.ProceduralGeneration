using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological
{
    public abstract class BaseGenerator<T, TContext> : IGeneratable<T, TContext>, IDisposable 
                                                                                 where T : AstronomicalObject
                                                                                 where TContext : BaseContext
    {
        private bool _disposed = false;

        protected readonly GeneratorSettings settings;
        protected readonly BasicGenerationSettings basicSettings;
        protected readonly AdvancedGenerationSettings advancedSettings;
        protected readonly AstronomicalObjectToggleSettings objectToggles;
        protected readonly TheoreticalAstronomicalObjectToggleSettings theoreticalObjectToggles;
        protected ParallelismLevel parallelismLevel = ParallelismLevel.Level0;
        private readonly SemaphoreSlim _semaphore;



        public BaseGenerator(ParallelismLevel parallelismLevel)
        {
            this.settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
            this.basicSettings = settings.Basic;
            this.advancedSettings = settings.Advanced;
            this.objectToggles = settings.ObjectToggles;
            this.theoreticalObjectToggles = settings.TheoreticalObjectToggles;
            this.parallelismLevel = parallelismLevel;
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

        protected int GetDegreesOfParallelism()
        {
            int calculated = 1;
            int configured = 1;

            switch(parallelismLevel)
            {
                case ParallelismLevel.Level0:
                    calculated = 1;
                    configured = 1;
                    break;
                case ParallelismLevel.Level1:
                    calculated = Environment.ProcessorCount;
                    configured = advancedSettings.MaxDegreesOfParallelismLevel1;
                    break;
                case ParallelismLevel.Level2:
                    calculated = Convert.ToInt32(0.75 * Environment.ProcessorCount);
                    configured = advancedSettings.MaxDegreesOfParallelismLevel2;
                    break;
                case ParallelismLevel.Level3:
                    calculated = Convert.ToInt32(0.5 * Environment.ProcessorCount);
                    configured = advancedSettings.MaxDegreesOfParallelismLevel3;
                    break;
                case ParallelismLevel.Level4:
                    calculated = Convert.ToInt32(0.25 * Environment.ProcessorCount);
                    configured = advancedSettings.MaxDegreesOfParallelismLevel4;
                    break;
            }

            if(configured < calculated)
            {
                return configured;
            }
            else
            {
                return calculated;
            }
        }

        public abstract Task<T> Generate(TContext context);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _semaphore?.Dispose();
                }

                _disposed = true;
            }
        }
    }
}