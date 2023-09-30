using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterSheetGenerationSettings : ISettings
    {
        [DisplayName("Count Age Factor")]
        [Tooltip("")]
        public double CountAgeFactor { get; set; }

        [DisplayName("Count Mass Factor")]
        [Tooltip("")]
        public double CountMassFactor { get; set; }

        [DisplayName("Count Size Factor")]
        [Tooltip("")]
        public double CountSizeFactor { get; set; }

        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double CountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double CountDarkMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double CountDarkEnergyPercentFactor { get; set; }




        public BaryonicMatterSheetGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterSheetCountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterSheetCountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterSheetCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterSheetCountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterSheetCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterSheetCountDarkEnergyPercentFactor;
        }
    }
}