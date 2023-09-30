using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterNodeGenerationSettings : ISettings
    {
        [DisplayName("Dark Matter Node Count Age Factor")]
        [Tooltip("")]
        public double DarkMatterNodeCountAgeFactor { get; set; }

        [DisplayName("Dark Matter Node Count Mass Factor")]
        [Tooltip("")]
        public double DarkMatterNodeCountMassFactor { get; set; }

        [DisplayName("Dark Matter Node Count Size Factor")]
        [Tooltip("")]
        public double DarkMatterNodeCountSizeFactor { get; set; }

        [DisplayName("Dark Matter Node Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterNodeCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Node Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterNodeCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Node Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterNodeCountDarkEnergyPercentFactor { get; set; }

        


        public DarkMatterNodeGenerationSettings()
        {
            
            this.DarkMatterNodeCountAgeFactor = ConfigConstants.DarkMatterNodeCountAgeFactor;
            this.DarkMatterNodeCountMassFactor = ConfigConstants.DarkMatterNodeCountMassFactor;
            this.DarkMatterNodeCountSizeFactor = ConfigConstants.DarkMatterNodeCountSizeFactor;
            this.DarkMatterNodeCountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterNodeCountBaryonicMatterPercentFactor;
            this.DarkMatterNodeCountDarkMatterPercentFactor = ConfigConstants.DarkMatterNodeCountDarkMatterPercentFactor;
            this.DarkMatterNodeCountDarkEnergyPercentFactor = ConfigConstants.DarkMatterNodeCountDarkEnergyPercentFactor;
        }
    }
}