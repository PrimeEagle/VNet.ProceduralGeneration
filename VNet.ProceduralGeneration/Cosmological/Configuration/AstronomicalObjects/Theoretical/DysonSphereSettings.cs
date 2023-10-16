using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects.Theoretical;

public class DysonSphereSettings : ISettings
{
    [Required]
    [DisplayName("Random Generation Algorithm")]
    [Tooltip("The algorithm used during object generation to generate random values.")]
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; init; }




    public DysonSphereSettings()
    {
        RandomGenerationAlgorithm = Constants.Advanced.Objects.Theoretical.DysonSphere.RandomGenerationAlgorithm;
    }
}
