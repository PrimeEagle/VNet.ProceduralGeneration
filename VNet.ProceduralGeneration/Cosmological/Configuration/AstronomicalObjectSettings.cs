using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;


namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class AstronomicalObjectSettings : ISettings
    {
        public BaryonicMatterFilamentSettings BaryonicMatterFilament { get; init; }
        public BaryonicMatterNodeSettings BaryonicMatterNode { get; init; }
        public BaryonicMatterSheetSettings BaryonicMatterSheet { get; init; }
        public BaryonicMatterVoidSettings BaryonicMatterVoid { get; init; }
        public CosmicWebSettings CosmicWeb { get; init; }
        public UniverseSettings Universe { get; init; }

        public AstronomicalObjectSettings()
        {
            Universe = new UniverseSettings();
            CosmicWeb = new CosmicWebSettings();
            BaryonicMatterNode = new BaryonicMatterNodeSettings();
            BaryonicMatterFilament = new BaryonicMatterFilamentSettings();
            BaryonicMatterSheet = new BaryonicMatterSheetSettings();
            BaryonicMatterVoid = new BaryonicMatterVoidSettings();
        }
    }
}