using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterNodeGenerationSettings : ISettings
    {
        [DisplayName("Baryonic Matter Node Count Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeCountAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Node Count Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeCountMassFactor { get; set; }

        [DisplayName("Baryonic Matter Node Count Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeCountSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Node Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Node Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Node Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterNodeCountDarkEnergyPercentFactor { get; set; }

        

        public BaryonicMatterNodeGenerationSettings()
        {
            this.BaryonicMatterNodeCountAgeFactor = ConfigConstants.BaryonicMatterNodeCountAgeFactor;
            this.BaryonicMatterNodeCountMassFactor = ConfigConstants.BaryonicMatterNodeCountMassFactor;
            this.BaryonicMatterNodeCountSizeFactor = ConfigConstants.BaryonicMatterNodeCountSizeFactor;
            this.BaryonicMatterNodeCountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterNodeCountBaryonicMatterPercentFactor;
            this.BaryonicMatterNodeCountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterNodeCountDarkMatterPercentFactor;
            this.BaryonicMatterNodeCountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterNodeCountDarkEnergyPercentFactor;
        }
    }
}