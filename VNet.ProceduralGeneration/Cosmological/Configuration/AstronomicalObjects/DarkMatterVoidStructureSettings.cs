using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class DarkMatterVoidStructureSettings
{
    [RangeLimitedToPercent<double>]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> OverlappingPercentRange { get; set; }

    [RangeLimitedTo<double>(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> OverlapRange { get; set; }

    [Range(0, 5)]
    [DisplayName("Parallelism Level")]
    [Tooltip("The level of parallelism used during generation. Higher numbers mean more parallel processes. Value = 0 means no parallelism.")]
    public int ParallelismLevel { get; init; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }

    [RangeLimitedToPercent<double>]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> VolumeCoveredByPercentRange { get; set; }

    public DarkMatterVoidStructureSettings()
    {
        OverlapRange = Constants.Advanced.Objects.DarkMatterVoidStructure.OverlapRange;
        OverlappingPercentRange = Constants.Advanced.Objects.DarkMatterVoidStructure.OverlappingPercentRange;
        VolumeCoveredByPercentRange = Constants.Advanced.Objects.DarkMatterVoidStructure.VolumeCoveredByPercentRange;
        RandomGenerationAlgorithm = Constants.Advanced.Objects.DarkMatterVoidStructure.RandomGenerationAlgorithm;
        ParallelismLevel = Constants.Advanced.Objects.DarkMatterVoidStructure.ParallelismLevel;
    }
}