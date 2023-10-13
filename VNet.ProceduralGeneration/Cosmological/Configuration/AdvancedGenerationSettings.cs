using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class AdvancedGenerationSettings : ISettings
{
    public AdvancedGenerationSettings()
    {
        Application = new ApplicationSettings();
        Universe = new UniverseGenerationSettings();
        CosmicWeb = new CosmicWebGenerationSettings();
        BaryonicMatterNode = new BaryonicMatterNodeGenerationSettings();
        BaryonicMatterFilament = new BaryonicMatterFilamentGenerationSettings();
        BaryonicMatterSheet = new BaryonicMatterSheetGenerationSettings();
        BaryonicMatterVoid = new BaryonicMatterVoidGenerationSettings();
        DarkMatterNode = new DarkMatterNodeGenerationSettings();
        DarkMatterFilament = new DarkMatterFilamentGenerationSettings();
        DarkMatterSheet = new DarkMatterSheetGenerationSettings();
        DarkMatterVoid = new DarkMatterVoidGenerationSettings();
        Plugin = new PluginSettings();
        PhysicalConstants = new PhysicalConstantsSettings();
    }

    public ApplicationSettings Application { get; init; }
    public UniverseGenerationSettings Universe { get; init; }
    public CosmicWebGenerationSettings CosmicWeb { get; init; }
    public BaryonicMatterNodeGenerationSettings BaryonicMatterNode { get; init; }
    public BaryonicMatterFilamentGenerationSettings BaryonicMatterFilament { get; init; }
    public BaryonicMatterSheetGenerationSettings BaryonicMatterSheet { get; init; }
    public BaryonicMatterVoidGenerationSettings BaryonicMatterVoid { get; init; }
    public DarkMatterNodeGenerationSettings DarkMatterNode { get; init; }
    public DarkMatterFilamentGenerationSettings DarkMatterFilament { get; init; }
    public DarkMatterSheetGenerationSettings DarkMatterSheet { get; init; }
    public DarkMatterVoidGenerationSettings DarkMatterVoid { get; init; }
    public PluginSettings Plugin { get; init; }
    public PhysicalConstantsSettings PhysicalConstants { get; init; }
}