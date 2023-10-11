using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.Scientific.Noise;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class CosmicWebGenerationRandomizedSettings : ISettings
    {
        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm BaryonicMatterNodeRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm BaryonicMatterNodeNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm BaryonicMatterFilamentRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm BaryonicMatterFilamentNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm BaryonicMatterSheetRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm BaryonicMatterSheetNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm BaryonicMatterVoidRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm BaryonicMatterVoidNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm DarkMatterNodeRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm DarkMatterNodeNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm DarkMatterFilamentRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm DarkMatterFilamentNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm DarkMatterSheetRandomizationAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm DarkMatterSheetNoiseAlgorithm { get; set; }

        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public IRandomGenerationAlgorithm DarkMatterVoidRandomizationAlgorithm { get; set; }
        
        [Required]
        [DisplayName("")]
        [Tooltip("")]
        public INoiseAlgorithm DarkMatterVoidNoiseAlgorithm { get; set; }

        
        
        
        public CosmicWebGenerationRandomizedSettings()
        {
            this.BaryonicMatterNodeRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterNodeRandomizationAlgorithm;
            this.BaryonicMatterNodeNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterNodeNoiseAlgorithm;
            this.BaryonicMatterFilamentRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterFilamentRandomizationAlgorithm;
            this.BaryonicMatterFilamentNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterFilamentNoiseAlgorithm;
            this.BaryonicMatterSheetRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterSheetRandomizationAlgorithm;
            this.BaryonicMatterSheetNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterSheetNoiseAlgorithm;
            this.BaryonicMatterVoidRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterVoidRandomizationAlgorithm;
            this.BaryonicMatterVoidNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterVoidNoiseAlgorithm;
            this.DarkMatterNodeRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterNodeRandomizationAlgorithm;
            this.DarkMatterNodeNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterNodeNoiseAlgorithm;
            this.DarkMatterFilamentRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterFilamentRandomizationAlgorithm;
            this.DarkMatterFilamentNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterFilamentNoiseAlgorithm;
            this.DarkMatterSheetRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterSheetRandomizationAlgorithm;
            this.DarkMatterSheetNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterSheetNoiseAlgorithm;
            this.DarkMatterVoidRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterVoidRandomizationAlgorithm;
            this.DarkMatterVoidNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterVoidNoiseAlgorithm;
        }
    }
}