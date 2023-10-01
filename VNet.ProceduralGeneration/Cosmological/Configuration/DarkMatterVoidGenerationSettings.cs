using System.ComponentModel;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterVoidGenerationSettings : ISettings
    {
        [DisplayName("Count Age Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter void count. Higher value results in more voids.")]
        public double CountAgeFactor { get; set; }

        [DisplayName("Count Mass Factor")]
        [Tooltip("Weighting factor for the age of the universe on dark matter void count. Higher value results in more voids.")]
        public double CountMassFactor { get; set; }

        [DisplayName("Count Size Factor")]
        [Tooltip("Weighting factor for the size of the universe on dark matter void count. Higher value results in more voids.")]
        public double CountSizeFactor { get; set; }

        [DisplayName("Count Baryonic Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter void count. Higher value results in more voids.")]
        public double CountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Matter Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark matter in the universe on dark matter void count. Higher value results in less voids.")]
        public double CountDarkMatterPercentFactor { get; set; }

        [DisplayName("Count Dark Energy Percent Factor")]
        [Tooltip("Weighting factor for the percentage of dark energy in the universe on dark matter void count. Higher value results in more voids.")]
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