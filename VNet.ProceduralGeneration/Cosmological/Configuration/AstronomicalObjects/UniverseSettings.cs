using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class UniverseSettings : ISettings
{
    [Required]
    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("Inflation Range")]
    [Tooltip("The range of inflation for the universe.")]
    public Range<float> InflationRange { get; init; }




    public UniverseSettings()
    {
        InflationRange = Constants.Advanced.Objects.Universe.InflationRange;
    }
}
