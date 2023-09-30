using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterSheetGenerationSettings : ISettings
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

        


        public DarkMatterSheetGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.DarkMatterSheetCountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterSheetCountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterSheetCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterSheetCountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterSheetCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterSheetCountDarkEnergyPercentFactor;
        }
    }
}