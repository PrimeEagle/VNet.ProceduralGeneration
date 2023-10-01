using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

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
            this.CountAgeFactor = ConfigConstants.DarkMatterFilament.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterFilament.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterFilament.CountSizeFactor;
            this.CountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterFilament.CountBaryonicMatterPercentFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterFilament.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterFilament.CountDarkEnergyPercentFactor;
        }
    }
}