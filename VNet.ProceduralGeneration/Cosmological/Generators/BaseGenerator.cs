using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration;

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


        public abstract T Generate(TContext context);

        public BaseGenerator()
        {
            this.settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
            this.basicSettings = settings.Basic;
            this.advancedSettings = settings.Advanced;
            this.objectToggles = settings.ObjectToggles;
            this.theoreticalObjectToggles = settings.TheoreticalObjectToggles;
        }
    }
}