using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterNodeGenerationSettings : ISettings
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

        

        public BaryonicMatterNodeGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterNodeCountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterNodeCountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterNodeCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterNodeCountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterNodeCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterNodeCountDarkEnergyPercentFactor;
        }
    }
}