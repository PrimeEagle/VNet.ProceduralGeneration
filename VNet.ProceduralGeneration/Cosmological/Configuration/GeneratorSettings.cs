using VNet.Configuration;


namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class GeneratorSettings : ISettings
    {
        public BasicGenerationSettings Basic { get; init; }
        public AdvancedGenerationSettings Advanced { get; init; }
        public AstronomicalObjectToggleSettings ObjectToggles { get; init;}
        public TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles { get; init; }



        public GeneratorSettings()
        {
            this.Basic = new BasicGenerationSettings();
            this.Advanced = new AdvancedGenerationSettings();
            this.ObjectToggles = new AstronomicalObjectToggleSettings();
            this.TheoreticalObjectToggles = new TheoreticalAstronomicalObjectToggleSettings();
        }
    }
}