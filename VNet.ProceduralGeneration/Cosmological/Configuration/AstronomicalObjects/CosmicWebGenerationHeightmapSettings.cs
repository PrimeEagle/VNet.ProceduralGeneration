using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using VNet.Configuration;
using VNet.Configuration.Attributes;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;


public class CosmicWebGenerationHeightmapSettings : ISettings
{
    [Range(1, 99)]
    [DisplayName("Gaussian Kernel Size")]
    [Tooltip("This value creates an n x n grid and, for each pixel, looks at other pixels contained in the grid to determine the amount of blur to apply.")]
    public int GaussianKernelSize { get; init; }

    [Range(0, float.MaxValue)]
    [DisplayName("Gaussian Sigma")]
    [Tooltip("The amount of gaussian blur to apply to the Heightmap Image File (0 = none).")]
    public float GaussianSigma { get; init; }

    public CosmicWebGenerationHeightmapSettings()
    {
        GaussianKernelSize = Constants.Advanced.Objects.CosmicWeb.GaussianKernelSize;
        GaussianSigma = Constants.Advanced.Objects.CosmicWeb.GaussianSigma;
    }
}