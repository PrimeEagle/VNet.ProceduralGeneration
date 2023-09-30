using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterFilamentGenerationSettings : ISettings
    {
        [DisplayName("Dark Matter Filament Count Age Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentCountAgeFactor { get; set; }

        [DisplayName("Dark Matter Filament Count Mass Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentCountMassFactor { get; set; }

        [DisplayName("Dark Matter Filament Count Size Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentCountSizeFactor { get; set; }

        [DisplayName("Dark Matter Filament Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Filament Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Filament Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterFilamentCountDarkEnergyPercentFactor { get; set; }




        public DarkMatterFilamentGenerationSettings()
        {
            this.DarkMatterFilamentCountAgeFactor = ConfigConstants.DarkMatterFilamentCountAgeFactor;
            this.DarkMatterFilamentCountMassFactor = ConfigConstants.DarkMatterFilamentCountMassFactor;
            this.DarkMatterFilamentCountSizeFactor = ConfigConstants.DarkMatterFilamentCountSizeFactor;
            this.DarkMatterFilamentCountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterFilamentCountBaryonicMatterPercentFactor;
            this.DarkMatterFilamentCountDarkMatterPercentFactor = ConfigConstants.DarkMatterFilamentCountDarkMatterPercentFactor;
            this.DarkMatterFilamentCountDarkEnergyPercentFactor = ConfigConstants.DarkMatterFilamentCountDarkEnergyPercentFactor;
        }
    }
}