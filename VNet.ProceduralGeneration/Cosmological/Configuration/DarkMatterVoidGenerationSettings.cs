using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

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
            this.CountAgeFactor = ConfigConstants.DarkMatterVoid.CountAgeFactor;
            this.CountMassFactor = ConfigConstants.DarkMatterVoid.CountMassFactor;
            this.CountSizeFactor = ConfigConstants.DarkMatterVoid.CountSizeFactor;
            this.CountDarkMatterPercentFactor = ConfigConstants.DarkMatterVoid.CountDarkMatterPercentFactor;
            this.CountDarkEnergyPercentFactor = ConfigConstants.DarkMatterVoid.CountDarkEnergyPercentFactor;
        }
    }
}