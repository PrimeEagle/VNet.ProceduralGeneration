using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class CosmicWebGenerationSettings : ISettings
    {
        [Required]
        [DisplayName("Random Generator")]
        [Tooltip("The random generation algorithm to use.")]
        public IRandomGenerationAlgorithm RandomGenerator { get; init; }




        public CosmicWebGenerationSettings()
        {
            this.RandomGenerator = ConfigConstants.Universe.RandomGenerator;
        }
    }
}