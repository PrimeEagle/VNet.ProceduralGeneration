using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class CosmicWebGenerationSettings : ISettings
{
    public CosmicWebGenerationSettings()
    {
        Evolution = new CosmicWebGenerationEvolutionSettings();
        Heightmap = new CosmicWebGenerationHeightmapSettings();
        Randomized = new CosmicWebGenerationRandomizedSettings();
        RandomGenerator = ConfigConstants.CosmicWeb.RandomGenerator;
        CosmicWebGenerationMethod = ConfigConstants.CosmicWeb.CosmicWebGenerationMethod;
    }

    public CosmicWebGenerationEvolutionSettings Evolution { get; set; }
    public CosmicWebGenerationHeightmapSettings Heightmap { get; set; }
    public CosmicWebGenerationRandomizedSettings Randomized { get; set; }

    [Required]
    [DisplayName("Random Generator")]
    [Tooltip("The random generation algorithm to use.")]
    public IRandomGenerationAlgorithm RandomGenerator { get; init; }

    [DisplayName("Cosmic Web Generation Method")]
    [Tooltip("What method should be used for generating the structure of the cosmic web.")]
    public CosmicWebGenerationMethod CosmicWebGenerationMethod { get; init; }
}