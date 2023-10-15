using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;
using VNet.Scientific.Noise;


// ReSharper disable PropertyCanBeMadeInitOnly.Global
namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class CosmicWebGenerationRandomizedSettings : ISettings
{
    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm BaryonicMatterFilamentNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm BaryonicMatterFilamentRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm BaryonicMatterNodeNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm BaryonicMatterNodeRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm BaryonicMatterRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm BaryonicMatterSheetNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm BaryonicMatterSheetRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm BaryonicMatterVoidNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm BaryonicMatterVoidRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm DarkMatterFilamentNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm DarkMatterFilamentRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm DarkMatterNodeNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm DarkMatterNodeRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm DarkMatterRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm DarkMatterSheetNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm DarkMatterSheetRandomizationAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public INoiseAlgorithm DarkMatterVoidNoiseAlgorithm { get; set; }

    [Required]
    [DisplayName("")]
    [Tooltip("")]
    public IRandomGenerationAlgorithm DarkMatterVoidRandomizationAlgorithm { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumBaryonicMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumBaryonicMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumBaryonicMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumBaryonicMatterVoidOverlap { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumDarkMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumDarkMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [GreaterThanOrEqualToProperty(nameof(MinimumDarkMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MaximumDarkMatterVoidOverlap { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumBaryonicMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumBaryonicMatterVoidDiameter { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumBaryonicMatterVoidOverlap))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumBaryonicMatterVoidOverlap { get; set; }

    [Range(0, float.MaxValue)]
    [LessThanOrEqualToProperty(nameof(MaximumDarkMatterVoidDiameter))]
    [DisplayName("")]
    [Tooltip("")]
    public float MinimumDarkMatterVoidDiameter { get; set; }

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

    [Range(0, 100)]
    [DisplayName("")]
    [Tooltip("")]
    public float PercentageOfVolumeCoveredByBaryonicMatterVoids { get; set; }

    [Range(0, 100)]
    [DisplayName("")]
    [Tooltip("")]
    public float PercentageOfVolumeCoveredByDarkMatterMatterVoids { get; set; }

    public CosmicWebGenerationRandomizedSettings()
    {
        BaryonicMatterNodeRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterNodeRandomizationAlgorithm;
        BaryonicMatterNodeNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterNodeNoiseAlgorithm;
        BaryonicMatterFilamentRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterFilamentRandomizationAlgorithm;
        BaryonicMatterFilamentNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterFilamentNoiseAlgorithm;
        BaryonicMatterSheetRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterSheetRandomizationAlgorithm;
        BaryonicMatterSheetNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterSheetNoiseAlgorithm;
        BaryonicMatterVoidRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterVoidRandomizationAlgorithm;
        BaryonicMatterVoidNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterVoidNoiseAlgorithm;
        DarkMatterNodeRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterNodeRandomizationAlgorithm;
        DarkMatterNodeNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterNodeNoiseAlgorithm;
        DarkMatterFilamentRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterFilamentRandomizationAlgorithm;
        DarkMatterFilamentNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterFilamentNoiseAlgorithm;
        DarkMatterSheetRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterSheetRandomizationAlgorithm;
        DarkMatterSheetNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterSheetNoiseAlgorithm;
        DarkMatterVoidRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterVoidRandomizationAlgorithm;
        DarkMatterVoidNoiseAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterVoidNoiseAlgorithm;
        PercentageOfVolumeCoveredByBaryonicMatterVoids = Constants.Advanced.Objects.CosmicWeb.PercentageOfVolumeCoveredByBaryonicMatterVoids;
        PercentageOfVolumeCoveredByDarkMatterMatterVoids = Constants.Advanced.Objects.CosmicWeb.PercentageOfVolumeCoveredByDarkMatterMatterVoids;
        MaximumBaryonicMatterVoidDiameter = Constants.Advanced.Objects.CosmicWeb.MaximumBaryonicMatterVoidDiameter;
        MaximumDarkMatterVoidDiameter = Constants.Advanced.Objects.CosmicWeb.MaximumDarkMatterVoidDiameter;
        MinimumBaryonicMatterVoidDiameter = Constants.Advanced.Objects.CosmicWeb.MinimumBaryonicMatterVoidDiameter;
        MinimumDarkMatterVoidDiameter = Constants.Advanced.Objects.CosmicWeb.MinimumDarkMatterVoidDiameter;
        MaximumBaryonicMatterVoidOverlap = Constants.Advanced.Objects.CosmicWeb.MaximumBaryonicMatterVoidOverlap;
        MaximumDarkMatterVoidOverlap = Constants.Advanced.Objects.CosmicWeb.MaximumDarkMatterVoidOverlap;
        MinimumBaryonicMatterVoidOverlap = Constants.Advanced.Objects.CosmicWeb.MinimumBaryonicMatterVoidOverlap;
        MinimumDarkMatterVoidOverlap = Constants.Advanced.Objects.CosmicWeb.MinimumDarkMatterVoidOverlap;
        PercentageOfOverlappingBaryonicMatterVoids = Constants.Advanced.Objects.CosmicWeb.PercentageOfOverlappingBaryonicMatterVoids;
        PercentageOfOverlappingDarkMatterVoids = Constants.Advanced.Objects.CosmicWeb.PercentageOfOverlappingDarkMatterVoids;
        BaryonicMatterRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterRandomizationAlgorithm;
        DarkMatterRandomizationAlgorithm = Constants.Advanced.Objects.CosmicWeb.DarkMatterRandomizationAlgorithm;
    }
}