using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class UniverseGenerationSettings : ISettings
    {
        [Required]
        [Range(0, float.MaxValue)]
        [DisplayName("Gaussian Sigma")]
        [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
        public float GaussianSigma { get; init; }

        [Required]
        [Range(0, double.MaxValue)]
        [DisplayName("Baseline Expansion Rate")]
        [Tooltip("The baseline expansion rate to use for comparisons. Defaults to expansion rate of the real universe. (km/s/Mpc)")]
        public double BaselineExpansionRate { get; init; }

        [Required]
        [Range(0, 10e32)]
        [DisplayName("Baseline Cosmic Microwave Background")]
        [Tooltip("The baseline cosmic microwave background to user for comparisons. Defaults to the cosmic microwave background of the real universe. (Kelvin)")]
        public double BaselineCosmicMicrowaveBackground { get; init; }

        [Required]
        [Range(0, 100)]
        [LessThanOrEqualToProperty(nameof(MaxConnectivityFactor))]
        [DisplayName("Min Connectivity Factor")]
        [Tooltip("The minimum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MinConnectivityFactor { get; init; }

        [Required]
        [Range(0, 100)]
        [GreaterThanOrEqualToProperty(nameof(MinConnectivityFactor))]
        [DisplayName("Max Connectivity Factor")]
        [Tooltip("The maximum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MaxConnectivityFactor { get; init; }



        public UniverseGenerationSettings()
        {
            this.GaussianSigma = ConfigConstants.Universe.GaussianSigma;
            this.BaselineExpansionRate = ConfigConstants.Universe.BaselineExpansionRate;
            this.BaselineCosmicMicrowaveBackground = ConfigConstants.Universe.BaselineCosmicMicrowaveBackground;
            this.MinConnectivityFactor = ConfigConstants.Universe.MinConnectivityFactor;
            this.MaxConnectivityFactor = ConfigConstants.Universe.MaxConnectivityFactor;
        }
    }
}