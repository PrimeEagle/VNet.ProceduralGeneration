using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;


namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

public class CosmicWebSettings : ISettings
{
    [DisplayName("Cosmic Web Generation Method")]
    [Tooltip("What method should be used for generating the structure of the cosmic web.")]
    public CosmicWebGenerationMethod CosmicWebGenerationMethod { get; init; }

    public CosmicWebGenerationEvolutionSettings Evolution { get; set; }

    public CosmicWebGenerationHeightmapSettings Heightmap { get; set; }

    [Required]
    [DisplayName("Random Generator")]
    [Tooltip("The random generation algorithm to use.")]
    public IRandomGenerationAlgorithm RandomGenerator { get; init; }

    public CosmicWebGenerationRandomizedSettings Randomized { get; set; }

    public CosmicWebSettings()
    {
        Evolution = new CosmicWebGenerationEvolutionSettings();
        Heightmap = new CosmicWebGenerationHeightmapSettings();
        Randomized = new CosmicWebGenerationRandomizedSettings();
        RandomGenerator = Constants.Advanced.Objects.CosmicWeb.RandomGenerator;
        CosmicWebGenerationMethod = Constants.Advanced.Objects.CosmicWeb.CosmicWebGenerationMethod;
    }
}