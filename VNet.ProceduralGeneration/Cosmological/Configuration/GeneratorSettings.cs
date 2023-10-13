using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class GeneratorSettings : ISettings
{
    public GeneratorSettings()
    {
        Basic = new BasicGenerationSettings();
        Advanced = new AdvancedGenerationSettings();
        ObjectToggles = new AstronomicalObjectToggleSettings();
        TheoreticalObjectToggles = new TheoreticalAstronomicalObjectToggleSettings();
    }

    public BasicGenerationSettings Basic { get; init; }
    public AdvancedGenerationSettings Advanced { get; init; }
    public AstronomicalObjectToggleSettings ObjectToggles { get; init; }
    public TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles { get; init; }
}