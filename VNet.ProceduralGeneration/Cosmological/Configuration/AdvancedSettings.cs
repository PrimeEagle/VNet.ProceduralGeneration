using VNet.Configuration.Attributes;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class AdvancedSettings
{
    [NotASetting]
    public ApplicationSettings Application { get; init; }

    [NotASetting]
    public AstronomicalObjectSettings Objects { get; init; }

    [NotASetting]
    public PhysicalConstantsSettings PhysicalConstants { get; init; }

    [NotASetting]
    public PluginSettings Plugin { get; init; }

    


    public AdvancedSettings()
    {
        Application = new ApplicationSettings();
        Plugin = new PluginSettings();
        PhysicalConstants = new PhysicalConstantsSettings();
        Objects = new AstronomicalObjectSettings();
    }
}