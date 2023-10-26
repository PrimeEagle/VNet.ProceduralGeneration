using VNet.Configuration;
using VNet.Configuration.Attributes;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class Settings : ISettings
{
    [NotASetting]
    public AdvancedSettings Advanced { get; init; }

    [NotASetting]
    public BasicSettings Basic { get; init; }
   
    
    
    
    public Settings()
    {
        Basic = new BasicSettings();
        Advanced = new AdvancedSettings();
    }
}