using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;

// ReSharper disable MemberCanBePrivate.Global

namespace VNet.ProceduralGeneration.Cosmological.Configuration;

public class BasicGenerationSettings : ISettings
{
    public BasicGenerationSettings()
    {
        DimensionX = ConfigConstants.Basic.DimensionX;
        DimensionY = ConfigConstants.Basic.DimensionY;
        DimensionZ = ConfigConstants.Basic.DimensionZ;
        MinDarkEnergyPercent = ConfigConstants.Basic.MinDarkEnergyPercent;
        MaxDarkEnergyPercent = ConfigConstants.Basic.MaxDarkEnergyPercent;
        MinDarkMatterPercent = ConfigConstants.Basic.MinDarkMatterPercent;
        MaxDarkMatterPercent = ConfigConstants.Basic.MaxDarkMatterPercent;
        MinBaryonicMatterPercent = ConfigConstants.Basic.MinBaryonicMatterPercent;
        MaxBaryonicMatterPercent = ConfigConstants.Basic.MaxBaryonicMatterPercent;
        MinUniverseAge = ConfigConstants.Basic.MinUniverseAge;
        MaxUniverseAge = ConfigConstants.Basic.MaxUniverseAge;
        ApplyGravitationalEffects = ConfigConstants.Basic.ApplyGravitationalEffects;
        HeightmapFolder = ConfigConstants.Basic.HeightmapFolder;
        HeightmapFile = ConfigConstants.Basic.HeightmapFile;
        LuaPluginFolder = ConfigConstants.Basic.LuaPluginFolder;
        CSharpPluginFolder = ConfigConstants.Basic.CSharpPluginFolder;
    }

    [Range(1, float.MaxValue)]
    [DisplayName("Dimension X")]
    [Tooltip("The size of the X-axis of the map (AU).")]
    public float DimensionX { get; init; }

    [Range(1, float.MaxValue)]
    [DisplayName("Dimension Y")]
    [Tooltip("The size of the Y-axis of the map (AU).")]
    public float DimensionY { get; init; }

    [Range(1, float.MaxValue)]
    [DisplayName("Dimension Z")]
    [Tooltip("The size of the Z-axis of the map (AU).")]
    public float DimensionZ { get; init; }

    [Range(0d, 100d)]
    [LessThanOrEqualToProperty(nameof(MaxDarkEnergyPercent))]
    [PercentageWithProperties(new[] {nameof(MinDarkMatterPercent), nameof(MinBaryonicMatterPercent)})]
    [DisplayName("Min Dark Energy Percent")]
    [Tooltip("Minimum amount of dark energy in the universe, as a percentage.")]
    public float MinDarkEnergyPercent { get; init; }

    [Range(0d, 100d)]
    [GreaterThanOrEqualToProperty(nameof(MinDarkEnergyPercent))]
    [PercentageWithProperties(new[] {nameof(MaxDarkMatterPercent), nameof(MaxBaryonicMatterPercent)})]
    [DisplayName("Max Dark Energy Percent")]
    [Tooltip("Maximum amount of dark energy in the universe, as a percentage.")]
    public float MaxDarkEnergyPercent { get; init; }

    [Range(0d, 100d)]
    [LessThanOrEqualToProperty(nameof(MaxDarkMatterPercent))]
    [PercentageWithProperties(new[] {nameof(MinDarkEnergyPercent), nameof(MinBaryonicMatterPercent)})]
    [DisplayName("Min Dark Matter Percent")]
    [Tooltip("Minimum amount of dark matter in the universe, as a percentage.")]
    public float MinDarkMatterPercent { get; init; }

    [Range(0d, 100d)]
    [GreaterThanOrEqualToProperty(nameof(MinDarkMatterPercent))]
    [PercentageWithProperties(new[] {nameof(MaxDarkEnergyPercent), nameof(MaxBaryonicMatterPercent)})]
    [DisplayName("Max Dark Matter Percent")]
    [Tooltip("Maximum amount of dark matter in the universe, as a percentage.")]
    public float MaxDarkMatterPercent { get; init; }

    [Range(0d, 100d)]
    [LessThanOrEqualToProperty(nameof(MaxBaryonicMatterPercent))]
    [PercentageWithProperties(new[] {nameof(MinDarkMatterPercent), nameof(MinDarkEnergyPercent)})]
    [DisplayName("Min Baryonic Matter Percent")]
    [Tooltip("Minimum amount of baryonic matter (normal matter) in the universe, as a percentage.")]
    public float MinBaryonicMatterPercent { get; init; }

    [Range(0d, 100d)]
    [GreaterThanOrEqualToProperty(nameof(MinBaryonicMatterPercent))]
    [PercentageWithProperties(new[] {nameof(MaxDarkMatterPercent), nameof(MaxDarkEnergyPercent)})]
    [DisplayName("Max Baryonic Matter Percent")]
    [Tooltip("Maximum amount of baryonic matter (normal matter) in the universe, as a percentage.")]
    public float MaxBaryonicMatterPercent { get; init; }

    [Range(0, 100e9)]
    [LessThanOrEqualToProperty(nameof(MaxUniverseAge))]
    [DisplayName("Min Universe Age")]
    [Tooltip("Minimum age of the universe, in years.")]
    public float MinUniverseAge { get; init; }

    [Range(0, 100e9)]
    [GreaterThanOrEqualToProperty(nameof(MinUniverseAge))]
    [DisplayName("Max Universe Age")]
    [Tooltip("Maximum age of the universe, in years.")]
    public float MaxUniverseAge { get; init; }

    [Required]
    [FileExists]
    [DisplayName("Heightmap File")]
    [Tooltip("A grayscale heightmap file which will be extruded into 3D and used to create the cosmic web.")]
    public string HeightmapFile { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Baryonic Matter Node Base Count")]
    [Tooltip("The starting number of baryonic matter (normal matter) nodes, before being adjusted due to environmental factors.")]
    public int BaryonicMatterNodeBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Baryonic Matter Filament Base Count")]
    [Tooltip("The starting number of baryonic matter (normal matter) filaments, before being adjusted due to environmental factors.")]
    public int BaryonicMatterFilamentBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Baryonic Matter Sheet Base Count")]
    [Tooltip("The starting number of baryonic matter (normal matter) sheets, before being adjusted due to environmental factors.")]
    public int BaryonicMatterSheetBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Baryonic Matter Void Base Count")]
    [Tooltip("The starting number of baryonic matter (normal matter) voids, before being adjusted due to environmental factors.")]
    public int BaryonicMatterVoidBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Dark Matter Node Base Count")]
    [Tooltip("The starting number of dark matter nodes, before being adjusted due to environmental factors.")]
    public int DarkMatterNodeBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Dark Matter Filament Base Count")]
    [Tooltip("The starting number of dark matter filaments, before being adjusted due to environmental factors.")]
    public int DarkMatterFilamentBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Dark Matter Sheet Base Count")]
    [Tooltip("The starting number of dark matter sheets, before being adjusted due to environmental factors.")]
    public int DarkMatterSheetBaseCount { get; init; }

    [Range(0, int.MaxValue)]
    [DisplayName("Dark Matter Void Base Count")]
    [Tooltip("The starting number of dark matter voids, before being adjusted due to environmental factors.")]
    public int DarkMatterVoidBaseCount { get; init; }

    [DisplayName("Apply Gravitational Effects")]
    [Tooltip("Whether contents of astronomical object containers should be adjusted due to gravity. Increases processing time.")]
    public bool ApplyGravitationalEffects { get; init; }

    [DisplayName("Average Dimension (Calculated)")]
    [Tooltip("Average of the map X, Y, and Z dimensions.")]
    public float AverageDimension => CalculateAverageDim();

    [DisplayName("Baryonic Matter Node Merge Distance Threshold (Calculated)")]
    [Tooltip("The maximum distance at which nearby baryonic matter nodes will be merged.")]
    public float TopologyBaryonicMatterNodeMergeDistanceThreshold => ConfigConstants.BaryonicMatterNode.TopologyMergeDistanceThresholdFactor * AverageDimension;

    [DisplayName("Baryonic Matter Node Max Distance (Calculated)")]
    [Tooltip("The maximum distance allowed between baryonic matter nodes. After merging has been processed, for nodes closer than this value, the least intense one will be removed.")]
    public float TopologyBaryonicMatterNodeMinDistanceThreshold => TopologyBaryonicMatterNodeMergeDistanceThreshold * ConfigConstants.BaryonicMatterNode.TopologyMinDistanceThresholdFactor;

    [DisplayName("Dark Matter Node Merge Distance Threshold (Calculated)")]
    [Tooltip("The maximum distance at which nearby dark matter nodes will be merged.")]
    public float TopologyDarkMatterNodeMergeDistanceThreshold => ConfigConstants.DarkMatterNode.TopologyMergeDistanceThresholdFactor * AverageDimension;

    [DisplayName("Dark Matter Node Max Distance (Calculated)")]
    [Tooltip("The maximum distance allowed between dark matter nodes. After merging has been processed, for nodes closer than this value, the least intense one will be removed.")]
    public float TopologyDarkMatterNodeMinDistanceThreshold => TopologyDarkMatterNodeMergeDistanceThreshold * ConfigConstants.DarkMatterNode.TopologyMinDistanceThresholdFactor;

    [Required]
    [DirectoryExists]
    [DisplayName("Heightmap Folder")]
    [Tooltip("The folder that contains heightmap files.")]
    public string HeightmapFolder { get; init; }

    [Required]
    [DirectoryExists]
    [DisplayName("Lua Plugin Folder")]
    [Tooltip("The folder that contains Lua plugins that should be loaded.")]
    public string LuaPluginFolder { get; init; }

    [Required]
    [DirectoryExists]
    [DisplayName("C# Plugin Folder")]
    [Tooltip("The folder that contains C# plugins that should be loaded.")]
    public string CSharpPluginFolder { get; init; }

    private float CalculateAverageDim()
    {
        return (DimensionX + DimensionY + DimensionZ) / 3;
    }
}