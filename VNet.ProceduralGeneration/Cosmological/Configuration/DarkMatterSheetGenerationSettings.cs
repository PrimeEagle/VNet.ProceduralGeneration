using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class DarkMatterSheetGenerationSettings : ISettings
    {
        [DisplayName("Dark Matter Sheet Count Age Factor")]
        [Tooltip("")]
        public double DarkMatterSheetCountAgeFactor { get; set; }

        [DisplayName("Dark Matter Sheet Count Mass Factor")]
        [Tooltip("")]
        public double DarkMatterSheetCountMassFactor { get; set; }

        [DisplayName("Dark Matter Sheet Count Size Factor")]
        [Tooltip("")]
        public double DarkMatterSheetCountSizeFactor { get; set; }

        [DisplayName("Dark Matter Sheet Count Baryonic Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterSheetCountBaryonicMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Sheet Count Dark Matter Percent Factor")]
        [Tooltip("")]
        public double DarkMatterSheetCountDarkMatterPercentFactor { get; set; }

        [DisplayName("Dark Matter Sheet Count Dark Energy Percent Factor")]
        [Tooltip("")]
        public double DarkMatterSheetCountDarkEnergyPercentFactor { get; set; }

        


        public DarkMatterSheetGenerationSettings()
        {
            this.DarkMatterSheetCountAgeFactor = ConfigConstants.DarkMatterSheetCountAgeFactor;
            this.DarkMatterSheetCountMassFactor = ConfigConstants.DarkMatterSheetCountMassFactor;
            this.DarkMatterSheetCountSizeFactor = ConfigConstants.DarkMatterSheetCountSizeFactor;
            this.DarkMatterSheetCountBaryonicMatterPercentFactor = ConfigConstants.DarkMatterSheetCountBaryonicMatterPercentFactor;
            this.DarkMatterSheetCountDarkMatterPercentFactor = ConfigConstants.DarkMatterSheetCountDarkMatterPercentFactor;
            this.DarkMatterSheetCountDarkEnergyPercentFactor = ConfigConstants.DarkMatterSheetCountDarkEnergyPercentFactor;
        }
    }
}