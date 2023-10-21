using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using VNet.Configuration;
using VNet.Configuration.Attributes;
using VNet.Configuration.Attributes.Validation;


// ReSharper disable MemberCanBePrivate.Global

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class BasicSettings
{
    [DisplayName("Average Dimension (Calculated)")]
    [Tooltip("Average of the map X, Y, and Z dimensions.")]
    internal float AverageDimension => (MapDimensions.X + MapDimensions.Y + MapDimensions.Z) / 3;

    [DisplayName("Apply Gravitational Effects")]
    [Tooltip("Whether contents of astronomical object containers should be adjusted due to gravity. Increases processing time.")]
    public bool ApplyGravitationalEffects { get; init; }

    [RangeLimitedToPercent]
    [RangeIsPercentageWithProperties(new[] { nameof(DarkMatterPercentRange), nameof(DarkEnergyPercentRange) })]
    [DisplayName("Baryonic Matter Percent Range")]
    [Tooltip("Range of baryonic matter (normal matter) in the universe, as a percentage.")]
    public Range<float> BaryonicMatterPercentRange { get; init; }

    [RangeLimitedToPercent]
    [RangeIsPercentageWithProperties(new[] { nameof(BaryonicMatterPercentRange), nameof(DarkMatterPercentRange) })]
    [RangeIfFalse(0, 0, "VNet.ProceduralGeneration.Cosmological.Configuration.TheoreticalAstronomicalObjectToggleSettings.DarkMatterEnabled")]
    [DisplayName("Dark Energy Percent Range")]
    [Tooltip("Range of dark energy in the universe, as a percentage.")]
    public Range<float> DarkEnergyPercentRange { get; init; }

    [RangeLimitedToPercent]
    [RangeIsPercentageWithProperties(new[] { nameof(BaryonicMatterPercentRange), nameof(DarkEnergyPercentRange) })]
    [RangeIfFalse(0, 0, "VNet.ProceduralGeneration.Cosmological.Configuration.TheoreticalAstronomicalObjectToggleSettings.DarkMatterEnabled")]
    [DisplayName("Dark Matter Percent Range")]
    [Tooltip("Range of dark matter in the universe, as a percentage.")]
    public Range<float> DarkMatterPercentRange { get; init; }

    [Required]
    [FileExists]
    [DisplayName("Heightmap File")]
    [Tooltip("A grayscale heightmap file which will be extruded into 3D and used to create the cosmic web.")]
    public string HeightmapFile { get; init; }

    [Required]
    [DirectoryExists]
    [DisplayName("Heightmap Folder")]
    [Tooltip("The folder that contains heightmap files.")]
    public string HeightmapFolder { get; init; }

    [Dimensions3D]
    [DisplayName("Map Dimensions")]
    [Tooltip("The dimensions of the map (AU).")]
    public Vector3 MapDimensions { get; init; }

    public AstronomicalObjectToggleSettings ObjectToggles { get; init; }

    [RangeLimitedTo(0d, 100d)]
    [DisplayName("Universe Age Range")]
    [Tooltip("Range of the age of the universe, in years.")]
    public Range<float> UniverseAgeRange { get; init; }




    public BasicSettings()
    {
        ObjectToggles = new AstronomicalObjectToggleSettings();
        MapDimensions = Constants.Basic.MapDimensions;
        DarkEnergyPercentRange = Constants.Basic.DarkEnergyPercentRange;
        DarkMatterPercentRange = Constants.Basic.DarkMatterPercentRange;
        BaryonicMatterPercentRange = Constants.Basic.BaryonicMatterPercentRange;
        UniverseAgeRange = Constants.Basic.UniverseAgeRange;
        ApplyGravitationalEffects = Constants.Basic.ApplyGravitationalEffects;
        HeightmapFolder = Constants.Basic.HeightmapFolder;
        HeightmapFile = Constants.Basic.HeightmapFile;
    }
}