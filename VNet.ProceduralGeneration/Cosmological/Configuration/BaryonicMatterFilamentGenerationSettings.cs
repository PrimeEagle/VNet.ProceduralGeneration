using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BaryonicMatterFilamentGenerationSettings : ISettings
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




        public BaryonicMatterFilamentGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.BaryonicMatterFilamentCountAgeFactor;
            this.CountMassFactor = ConfigConstants.BaryonicMatterFilamentCountMassFactor;
            this.CountSizeFactor = ConfigConstants.BaryonicMatterFilamentCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.BaryonicMatterFilamentCountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.BaryonicMatterFilamentCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.BaryonicMatterFilamentCountDarkEnergyPercentFactor;
        }
    }
}