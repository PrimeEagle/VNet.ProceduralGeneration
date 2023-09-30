using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterNodeGenerationSettings : ISettings
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

        


        public DarkMatterNodeGenerationSettings()
        {
            
            this.CountAgeFactor = ConfigConstants.DarkMatterNodeCountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterNodeCountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterNodeCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterNodeCountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterNodeCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterNodeCountDarkEnergyPercentFactor;
        }
    }
}