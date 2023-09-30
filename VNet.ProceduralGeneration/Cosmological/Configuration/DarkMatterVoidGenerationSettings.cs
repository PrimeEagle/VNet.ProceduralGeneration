using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterVoidGenerationSettings : ISettings
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

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double CountDarkMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double CountDarkEnergyPercentFactor { get; set; }

        


        public DarkMatterVoidGenerationSettings()
        {
            this.CountAgeFactor = ConfigConstants.DarkMatterVoidCountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterVoidCountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterVoidCountSizeFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterVoidCountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterVoidCountDarkEnergyPercentFactor;
        }
    }
}