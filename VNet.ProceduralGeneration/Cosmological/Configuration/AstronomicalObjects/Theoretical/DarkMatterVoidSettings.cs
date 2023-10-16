using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects.Theoretical;

public class DarkMatterVoidSettings : ISettings
{
    [RangeLimitedTo(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> DiameterRange { get; set; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }




    public DarkMatterVoidSettings()
    {
        DiameterRange = Constants.Advanced.Objects.Theoretical.DarkMatterVoid.DiameterRange;
        RandomGenerationAlgorithm = Constants.Advanced.Objects.Theoretical.DarkMatterVoid.RandomGenerationAlgorithm;
    }
}