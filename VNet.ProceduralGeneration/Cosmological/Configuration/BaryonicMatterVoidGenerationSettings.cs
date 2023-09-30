using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterVoidGenerationSettings : ISettings
    {
        [DisplayName("Baryonic Matter Void Count Age Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidCountAgeFactor { get; set; }

        [DisplayName("Baryonic Matter Void Count Mass Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidCountMassFactor { get; set; }

        [DisplayName("Baryonic Matter Void Count Size Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidCountSizeFactor { get; set; }

        [DisplayName("Baryonic Matter Void Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Baryonic Matter Void Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double BaryonicMatterVoidCountDarkEnergyPercentFactor { get; set; }

       


        public BaryonicMatterVoidGenerationSettings()
        {
            this.BaryonicMatterVoidCountAgeFactor = ConfigConstants.BaryonicMatterVoidCountAgeFactor;
            this.BaryonicMatterVoidCountMassFactor = ConfigConstants.BaryonicMatterVoidCountMassFactor;
            this.BaryonicMatterVoidCountSizeFactor = ConfigConstants.BaryonicMatterVoidCountSizeFactor;
            this.BaryonicMatterVoidCountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterVoidCountBaryonicMatterPercentFactor;
            this.BaryonicMatterVoidCountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterVoidCountDarkEnergyPercentFactor;
        }
    }
}