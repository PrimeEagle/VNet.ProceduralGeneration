using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class BaryonicMatterVoidStructureSettings
{
    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }

    [RangeLimitedToPercent]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> OverlappingPercentRange { get; set; }

    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> OverlapRange { get; set; }

    [RangeLimitedToPercent]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> VolumeCoveredByPercentRange { get; set; }




    public BaryonicMatterVoidStructureSettings()
    {
        VolumeCoveredByPercentRange = Constants.Advanced.Objects.BaryonicMatterVoidStructure.VolumeCoveredByPercentRange;
        OverlapRange = Constants.Advanced.Objects.BaryonicMatterVoidStructure.OverlapRange;
        OverlappingPercentRange = Constants.Advanced.Objects.BaryonicMatterVoidStructure.OverlappingPercentRange;
        RandomGenerationAlgorithm = Constants.Advanced.Objects.BaryonicMatterVoidStructure.RandomGenerationAlgorithm;
    }
}