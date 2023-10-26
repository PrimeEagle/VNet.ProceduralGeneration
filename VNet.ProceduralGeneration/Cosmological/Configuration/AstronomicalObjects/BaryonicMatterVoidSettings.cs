using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class BaryonicMatterVoidSettings
{
    [RangeLimitedTo<double>(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> DiameterRange { get; set; }


    public BaryonicMatterVoidSettings()
    {
        DiameterRange = Constants.Advanced.Objects.BaryonicMatterVoid.DiameterRange;
    }
}