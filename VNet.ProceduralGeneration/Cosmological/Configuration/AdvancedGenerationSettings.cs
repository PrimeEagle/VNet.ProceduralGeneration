using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AdvancedGenerationSettings : ISettings
    {
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




        public AdvancedGenerationSettings()
        {
            this.Application = new ApplicationSettings();
            this.Universe = new UniverseGenerationSettings();
            this.CosmicWeb = new CosmicWebGenerationSettings();
            this.BaryonicMatterNode = new BaryonicMatterNodeGenerationSettings();
            this.BaryonicMatterFilament = new BaryonicMatterFilamentGenerationSettings();
            this.BaryonicMatterSheet = new BaryonicMatterSheetGenerationSettings();
            this.BaryonicMatterVoid = new BaryonicMatterVoidGenerationSettings();
            this.DarkMatterNode = new DarkMatterNodeGenerationSettings();
            this.DarkMatterFilament = new DarkMatterFilamentGenerationSettings();
            this.DarkMatterSheet = new DarkMatterSheetGenerationSettings();
            this.DarkMatterVoid = new DarkMatterVoidGenerationSettings();
            this.Plugin = new PluginSettings();
            this.PhysicalConstants = new PhysicalConstantsSettings();
        }
    }
}