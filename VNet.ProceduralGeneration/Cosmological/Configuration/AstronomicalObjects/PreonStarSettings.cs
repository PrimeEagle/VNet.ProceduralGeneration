using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class PreonStarSettings
{
    [Range(0, 5)]
    [DisplayName("Parallelism Level")]
    [Tooltip("The level of parallelism used during generation. Higher numbers mean more parallel processes. Value = 0 means no parallelism.")]
    public int ParallelismLevel { get; init; }

    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }

    public PreonStarSettings()
    {
        RandomGenerationAlgorithm = Constants.Advanced.Objects.PreonStar.RandomGenerationAlgorithm;
        ParallelismLevel = Constants.Advanced.Objects.PreonStar.ParallelismLevel;
    }
}