using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class UniverseGenerationSettings : ISettings
    {
        [Range(0, float.MaxValue)]
        [DisplayName("Gaussian Sigma")]
        [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
        public float GaussianSigma { get; init; }

        [Range(0, double.MaxValue)]
        [DisplayName("Baseline Expansion Rate")]
        [Tooltip("The baseline expansion rate to use for comparisons. Defaults to expansion rate of the real universe. (km/s/Mpc)")]
        public double BaselineExpansionRate { get; init; }

        [Range(0, 10e32)]
        [DisplayName("Baseline Cosmic Microwave Background")]
        [Tooltip("The baseline cosmic microwave background to user for comparisons. Defaults to the cosmic microwave background of the real universe. (Kelvin)")]
        public double BaselineCosmicMicrowaveBackground { get; init; }

        [Range(0, 100)]
        [LessThanOrEqualToProperty(nameof(MaxConnectivityFactor))]
        [DisplayName("Min Connectivity Factor")]
        [Tooltip("The minimum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MinConnectivityFactor { get; init; }

        [Range(0, 100)]
        [GreaterThanOrEqualToProperty(nameof(MinConnectivityFactor))]
        [DisplayName("Max Connectivity Factor")]
        [Tooltip("The maximum amount that the universes curves or folds to connect distant locations. Affect amount of wormholes. (0 = none, 100 = max)")]
        public float MaxConnectivityFactor { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CurvatureSphericalPercentage), nameof(CurvatureHyperbolicPercentage) })]
        [DisplayName("Curvature Flat Percentage")]
        [Tooltip("Probability of the curvature of the universe being flat, as a percentage.")]
        public float CurvatureFlatPercentage { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CurvatureFlatPercentage), nameof(CurvatureHyperbolicPercentage) })]
        [DisplayName("Curvature Spherical Percentage")]
        [Tooltip("Probability of the curvature of the universe being spherical, as a percentage.")]
        public float CurvatureSphericalPercentage { get; init; }

        [Range(0, 100)]
        [PercentageWithProperties(new string[] { nameof(CurvatureFlatPercentage), nameof(CurvatureSphericalPercentage) })]
        [DisplayName("Curvature Hyperbolic Percentage")]
        [Tooltip("Probability of the curvature of the universe being hyperbolic, as a percentage.")]
        public float CurvatureHyperbolicPercentage { get; init; }

        [Required]
        [DisplayName("Random Generator")]
        [Tooltip("The random generation algorithm to use.")]
        public IRandomGenerationAlgorithm RandomGenerator { get; init; }




        public UniverseGenerationSettings()
        {
            this.GaussianSigma = ConfigConstants.Universe.GaussianSigma;
            this.BaselineExpansionRate = ConfigConstants.Universe.BaselineExpansionRate;
            this.BaselineCosmicMicrowaveBackground = ConfigConstants.Universe.BaselineCosmicMicrowaveBackground;
            this.MinConnectivityFactor = ConfigConstants.Universe.MinConnectivityFactor;
            this.MaxConnectivityFactor = ConfigConstants.Universe.MaxConnectivityFactor;
            this.CurvatureFlatPercentage = ConfigConstants.Universe.CurvatureFlatPercentage;
            this.CurvatureSphericalPercentage = ConfigConstants.Universe.CurvatureSphericalPercentage;
            this.CurvatureHyperbolicPercentage = ConfigConstants.Universe.CurvatureHyperbolicPercentage;
            this.RandomGenerator = ConfigConstants.Universe.RandomGenerator;
        }
    }
}