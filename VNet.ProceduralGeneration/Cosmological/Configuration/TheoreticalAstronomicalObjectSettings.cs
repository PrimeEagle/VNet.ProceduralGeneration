using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.TheoreticalAstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class TheoreticalAstronomicalObjectSettings : ISettings
    {
        public DarkMatterFilamentSettings DarkMatterFilament { get; init; }
        public DarkMatterNodeSettings DarkMatterNode { get; init; }
        public DarkMatterSheetSettings DarkMatterSheet { get; init; }
        public DarkMatterVoidSettings DarkMatterVoid { get; init; }

        public TheoreticalAstronomicalObjectSettings()
        {
            DarkMatterNode = new DarkMatterNodeSettings();
            DarkMatterFilament = new DarkMatterFilamentSettings();
            DarkMatterSheet = new DarkMatterSheetSettings();
            DarkMatterVoid = new DarkMatterVoidSettings();
        }
    }
}