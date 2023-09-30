using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological
{
    public abstract class BaseGenerator<T, TContext> : IGeneratable<T, TContext> where T : AstronomicalObject
                                                                                 where TContext : BaseContext
    {
        protected readonly GeneratorSettings settings;
        protected readonly BasicGenerationSettings basicSettings;
        protected readonly AdvancedGenerationSettings advancedSettings;
        protected readonly AstronomicalObjectToggleSettings objectToggles;
        protected readonly TheoreticalAstronomicalObjectToggleSettings theoreticalObjectToggles;
        protected ParallelismLevel parallelismLevel = ParallelismLevel.LimitOne;




        public abstract Task<T> Generate(TContext context);

        public BaseGenerator()
        {
            this.settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
            this.basicSettings = settings.Basic;
            this.advancedSettings = settings.Advanced;
            this.objectToggles = settings.ObjectToggles;
            this.theoreticalObjectToggles = settings.TheoreticalObjectToggles;
        }

        protected int GetDegreesOfParallelism()
        {
            int calculated = 1;
            int configured = 1;

            switch(parallelismLevel)
            {
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
    }
}