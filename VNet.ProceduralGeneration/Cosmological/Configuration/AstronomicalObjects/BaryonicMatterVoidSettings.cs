using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class BaryonicMatterVoidSettings
{
    [Range(0, 5)]
    [DisplayName("Parallelism Level")]
    [Tooltip("The level of parallelism used during generation. Higher numbers mean more parallel processes. Value = 0 means no parallelism.")]
    public int ParallelismLevel { get; init; }

    [RangeLimitedTo<double>(0, float.MaxValue)]
    [DisplayName("")]
    [Tooltip("")]
    public Range<float> DiameterRange { get; set; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }


    public BaryonicMatterVoidSettings()
    {
        RandomGenerationAlgorithm = Constants.Advanced.Objects.BlackHole.RandomGenerationAlgorithm;
        DiameterRange = Constants.Advanced.Objects.BaryonicMatterVoid.DiameterRange;
        ParallelismLevel = Constants.Advanced.Objects.BaryonicMatterVoid.ParallelismLevel;
    }
}