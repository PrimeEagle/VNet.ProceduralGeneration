using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterFilamentGenerationSettings : ISettings
    {
        [DisplayName("Baryonic Matter Filament Count Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentCountAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Count Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentCountMassFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Count Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentCountSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Filament Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterFilamentCountDarkEnergyPercentFactor { get; set; }




        public BaryonicMatterFilamentGenerationSettings()
        {
            this.BaryonicMatterFilamentCountAgeFactor = ConfigConstants.BaryonicMatterFilamentCountAgeFactor;
            this.BaryonicMatterFilamentCountMassFactor = ConfigConstants.BaryonicMatterFilamentCountMassFactor;
            this.BaryonicMatterFilamentCountSizeFactor = ConfigConstants.BaryonicMatterFilamentCountSizeFactor;
            this.BaryonicMatterFilamentCountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterFilamentCountBaryonicMatterPercentFactor;
            this.BaryonicMatterFilamentCountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterFilamentCountDarkMatterPercentFactor;
            this.BaryonicMatterFilamentCountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterFilamentCountDarkEnergyPercentFactor;
        }
    }
}