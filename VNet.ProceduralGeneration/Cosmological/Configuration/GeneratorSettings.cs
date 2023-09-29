using VNet.Configuration;


namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class GeneratorSettings : ISettings
    {
        public BasicGenerationSettings Basic { get; set; }
        public AdvancedGenerationSettings Advanced { get; set; }
        public AstronomicalObjectToggleSettings ObjectToggles { get; set;}
        public TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles { get; set; }



        public GeneratorSettings()
        {
            this.Basic = new BasicGenerationSettings();
            this.Advanced = new AdvancedGenerationSettings();
            this.ObjectToggles = new AstronomicalObjectToggleSettings();
            this.TheoreticalObjectToggles = new TheoreticalAstronomicalObjectToggleSettings();
        }
    }
}