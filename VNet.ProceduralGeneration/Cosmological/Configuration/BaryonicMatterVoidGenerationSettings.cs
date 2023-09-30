using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterVoidGenerationSettings : ISettings
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

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double CountDarkEnergyPercentFactor { get; set; }

       


        public BaryonicMatterVoidGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterVoidCountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterVoidCountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterVoidCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterVoidCountBaryonicMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterVoidCountDarkEnergyPercentFactor;
        }
    }
}