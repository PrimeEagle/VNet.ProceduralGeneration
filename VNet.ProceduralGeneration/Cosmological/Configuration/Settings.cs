using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class Settings : ISettings
{
    public AdvancedSettings Advanced { get; init; }

    public BasicSettings Basic { get; init; }

    public Settings()
    {
        Basic = new BasicSettings();
        Advanced = new AdvancedSettings();
    }
}