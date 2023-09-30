using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterFilamentGenerationSettings : ISettings
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




        public DarkMatterFilamentGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.DarkMatterFilamentCountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterFilamentCountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterFilamentCountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterFilamentCountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterFilamentCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterFilamentCountDarkEnergyPercentFactor;
        }
    }
}