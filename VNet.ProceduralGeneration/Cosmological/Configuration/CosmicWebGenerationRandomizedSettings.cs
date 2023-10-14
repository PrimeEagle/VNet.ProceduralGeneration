using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.Scientific.Noise;

// ReSharper disable PropertyCanBeMadeInitOnly.Global


namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class CosmicWebGenerationRandomizedSettings : ISettings
{
    public CosmicWebGenerationRandomizedSettings()
    {
        BaryonicMatterNodeRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterNodeRandomizationAlgorithm;
        BaryonicMatterNodeNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterNodeNoiseAlgorithm;
        BaryonicMatterFilamentRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterFilamentRandomizationAlgorithm;
        BaryonicMatterFilamentNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterFilamentNoiseAlgorithm;
        BaryonicMatterSheetRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterSheetRandomizationAlgorithm;
        BaryonicMatterSheetNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterSheetNoiseAlgorithm;
        BaryonicMatterVoidRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterVoidRandomizationAlgorithm;
        BaryonicMatterVoidNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterVoidNoiseAlgorithm;
        DarkMatterNodeRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterNodeRandomizationAlgorithm;
        DarkMatterNodeNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterNodeNoiseAlgorithm;
        DarkMatterFilamentRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterFilamentRandomizationAlgorithm;
        DarkMatterFilamentNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterFilamentNoiseAlgorithm;
        DarkMatterSheetRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterSheetRandomizationAlgorithm;
        DarkMatterSheetNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterSheetNoiseAlgorithm;
        DarkMatterVoidRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterVoidRandomizationAlgorithm;
        DarkMatterVoidNoiseAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterVoidNoiseAlgorithm;
        PercentageOfVolumeCoveredByBaryonicMatterVoids = ConfigConstants.CosmicWebRandomized.PercentageOfVolumeCoveredByBaryonicMatterVoids;
        PercentageOfVolumeCoveredByDarkMatterMatterVoids = ConfigConstants.CosmicWebRandomized.PercentageOfVolumeCoveredByDarkMatterMatterVoids;
        MaximumBaryonicMatterVoidDiameter = ConfigConstants.CosmicWebRandomized.MaximumBaryonicMatterVoidDiameter;
        MaximumDarkMatterVoidDiameter = ConfigConstants.CosmicWebRandomized.MaximumDarkMatterVoidDiameter;
        MinimumBaryonicMatterVoidDiameter = ConfigConstants.CosmicWebRandomized.MinimumBaryonicMatterVoidDiameter;
        MinimumDarkMatterVoidDiameter = ConfigConstants.CosmicWebRandomized.MinimumDarkMatterVoidDiameter;
        MaximumBaryonicMatterVoidOverlap = ConfigConstants.CosmicWebRandomized.MaximumBaryonicMatterVoidOverlap;
        MaximumDarkMatterVoidOverlap = ConfigConstants.CosmicWebRandomized.MaximumDarkMatterVoidOverlap;
        MinimumBaryonicMatterVoidOverlap = ConfigConstants.CosmicWebRandomized.MinimumBaryonicMatterVoidOverlap;
        MinimumDarkMatterVoidOverlap = ConfigConstants.CosmicWebRandomized.MinimumDarkMatterVoidOverlap;
        PercentageOfOverlappingBaryonicMatterVoids = ConfigConstants.CosmicWebRandomized.PercentageOfOverlappingBaryonicMatterVoids;
        PercentageOfOverlappingDarkMatterVoids = ConfigConstants.CosmicWebRandomized.PercentageOfOverlappingDarkMatterVoids;
        BaryonicMatterRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.BaryonicMatterRandomizationAlgorithm;
        DarkMatterRandomizationAlgorithm = ConfigConstants.CosmicWebRandomized.DarkMatterRandomizationAlgorithm;
    }

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

    [Range(0, 100)]
    [DisplayName("")]
    [Tooltip("")]
    public float PercentageOfVolumeCoveredByBaryonicMatterVoids { get; set; }

    [Range(0, 100)]
    [DisplayName("")]
    [Tooltip("")]
    public float PercentageOfVolumeCoveredByDarkMatterMatterVoids { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumBaryonicMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumBaryonicMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumDarkMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumDarkMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumBaryonicMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumBaryonicMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumDarkMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumDarkMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumBaryonicMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumBaryonicMatterVoidOverlap { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumDarkMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumDarkMatterVoidOverlap { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumBaryonicMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumBaryonicMatterVoidOverlap { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumDarkMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumDarkMatterVoidOverlap { get; set; }

    [Range(0, 100)]
    [DisplayName("")]
    [Tooltip("")]
    public float PercentageOfOverlappingBaryonicMatterVoids { get; set; }

    [Range(0, 100)]
    [DisplayName("")]
    [Tooltip("")]
    public float PercentageOfOverlappingDarkMatterVoids { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm BaryonicMatterRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm DarkMatterRandomizationAlgorithm { get; set; }
}