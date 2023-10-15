using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;


// ReSharper disable PropertyCanBeMadeInitOnly.Global
namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class CosmicWebGenerationRandomizedSettings : ISettings
{
    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> BaryonicMatterVoidDiameterRange { get; set; }

    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> DarkMatterVoidDiameterRange { get; set; }

    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> BaryonicMatterVoidOverlapRange { get; set; }

    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> DarkMatterVoidOverlapRange { get; set; }

    [RangeLimitedToPercent]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> OverlappingBaryonicMatterVoidsPercentRange { get; set; }

    [RangeLimitedToPercent]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> OverlappingDarkMatterVoidsPercentRange { get; set; }

    [RangeLimitedToPercent]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> VolumeCoveredByBaryonicMatterVoidsPercentRange { get; set; }

    [RangeLimitedToPercent]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> VolumeCoveredByDarkMatterMatterVoidsPercentRange { get; set; }

    public CosmicWebGenerationRandomizedSettings()
    {
        BaryonicMatterVoidDiameterRange = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterVoidDiameterRange;
        DarkMatterVoidDiameterRange = Constants.Advanced.Objects.CosmicWeb.DarkMatterVoidDiameterRange;
        BaryonicMatterVoidOverlapRange = Constants.Advanced.Objects.CosmicWeb.BaryonicMatterVoidOverlapRange;
        DarkMatterVoidOverlapRange = Constants.Advanced.Objects.CosmicWeb.DarkMatterVoidOverlapRange;
        OverlappingBaryonicMatterVoidsPercentRange = Constants.Advanced.Objects.CosmicWeb.OverlappingBaryonicMatterVoidsPercentRange;
        OverlappingDarkMatterVoidsPercentRange = Constants.Advanced.Objects.CosmicWeb.OverlappingDarkMatterVoidsPercentRange;
        VolumeCoveredByBaryonicMatterVoidsPercentRange = Constants.Advanced.Objects.CosmicWeb.VolumeCoveredByBaryonicMatterVoidsPercentRange;
        VolumeCoveredByDarkMatterMatterVoidsPercentRange = Constants.Advanced.Objects.CosmicWeb.VolumeCoveredByDarkMatterMatterVoidsPercentRange;
    }
}