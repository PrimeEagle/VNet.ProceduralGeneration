using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class AdvancedSettings : ISettings
{
    public ApplicationSettings Application { get; init; }

    public AstronomicalObjectSettings Objects { get; init; }

    public PhysicalConstantsSettings PhysicalConstants { get; init; }

    public PluginSettings Plugin { get; init; }

    

    public AdvancedSettings()
    {
        Application = new ApplicationSettings();
        Plugin = new PluginSettings();
        PhysicalConstants = new PhysicalConstantsSettings();
        Objects = new AstronomicalObjectSettings();
    }
}