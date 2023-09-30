using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterSheetGenerationSettings : ISettings
    {
        [DisplayName("Baryonic Matter Sheet Count Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetCountAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Count Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetCountMassFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Count Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetCountSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Sheet Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterSheetCountDarkEnergyPercentFactor { get; set; }




        public BaryonicMatterSheetGenerationSettings()
        {
            this.BaryonicMatterSheetCountAgeFactor = ConfigConstants.BaryonicMatterSheetCountAgeFactor;
            this.BaryonicMatterSheetCountMassFactor = ConfigConstants.BaryonicMatterSheetCountMassFactor;
            this.BaryonicMatterSheetCountSizeFactor = ConfigConstants.BaryonicMatterSheetCountSizeFactor;
            this.BaryonicMatterSheetCountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterSheetCountBaryonicMatterPercentFactor;
            this.BaryonicMatterSheetCountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterSheetCountDarkMatterPercentFactor;
            this.BaryonicMatterSheetCountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterSheetCountDarkEnergyPercentFactor;
        }
    }
}