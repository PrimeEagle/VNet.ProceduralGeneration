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

    [RangeLimitedToPercent<double>]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> VolumeCoveredByPercentRange { get; set; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }




    public DarkMatterVoidStructureSettings()
    {
        OverlapRange = Constants.Advanced.Objects.Theoretical.DarkMatterVoidStructure.OverlapRange;
        OverlappingPercentRange = Constants.Advanced.Objects.Theoretical.DarkMatterVoidStructure.OverlappingPercentRange;
        VolumeCoveredByPercentRange = Constants.Advanced.Objects.Theoretical.DarkMatterVoidStructure.VolumeCoveredByPercentRange;
        RandomGenerationAlgorithm = Constants.Advanced.Objects.Theoretical.DarkMatterVoidStructure.RandomGenerationAlgorithm;
    }
}