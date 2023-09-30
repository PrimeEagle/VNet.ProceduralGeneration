using System.ComponentModel;
using VNet.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterVoidGenerationSettings : ISettings
    {
        [DisplayName("Dark Matter Void Count Age Factor")]
        [Tooltip("")]
        public double DarkMatterVoidCountAgeFactor { get; set; }

        [DisplayName("Dark Matter Void Count Mass Factor")]
        [Tooltip("")]
        public double DarkMatterVoidCountMassFactor { get; set; }

        [DisplayName("Dark Matter Void Count Size Factor")]
        [Tooltip("")]
        public double DarkMatterVoidCountSizeFactor { get; set; }

        [DisplayName("Dark Matter Void Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterVoidCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Void Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterVoidCountDarkEnergyPercentFactor { get; set; }

        


        public DarkMatterVoidGenerationSettings()
        {
            this.DarkMatterVoidCountAgeFactor = ConfigConstants.DarkMatterVoidCountAgeFactor;
            this.DarkMatterVoidCountMassFactor = ConfigConstants.DarkMatterVoidCountMassFactor;
            this.DarkMatterVoidCountSizeFactor = ConfigConstants.DarkMatterVoidCountSizeFactor;
            this.DarkMatterVoidCountDarkMatterPercentFactor = ConfigConstants.DarkMatterVoidCountDarkMatterPercentFactor;
            this.DarkMatterVoidCountDarkEnergyPercentFactor = ConfigConstants.DarkMatterVoidCountDarkEnergyPercentFactor;
        }
    }
}