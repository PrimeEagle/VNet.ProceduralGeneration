using System.Collections.ObjectModel;
using VNet.Configuration.Attributes;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class Settings
{
    [NotASetting]
    public AdvancedSettings Advanced { get; init; }

    [NotASetting]
    public BasicSettings Basic { get; init; }


    public ObservableCollection<string> TabNames { get; } = new ObservableCollection<string> { "One", "Two", "Three", "Four" };
    
    
    
    
    public Settings()
    {
        Basic = new BasicSettings();
        Advanced = new AdvancedSettings();
    }
}