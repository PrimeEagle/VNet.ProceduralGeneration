using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.Constants;
// ReSharper disable MemberCanBePrivate.Global

namespace VNet.ProceduralGeneration.Cosmological.Configuration
{
    public class BasicGenerationSettings : ISettings
    {
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
        [PercentageWithProperties(new string[] { nameof(MinDarkMatterPercent), nameof(MinBaryonicMatterPercent) })]
        [DisplayName("Min Dark Energy Percent")]
        [Tooltip("Minimum amount of dark energy in the universe, as a percentage.")]
        public double MinDarkEnergyPercent { get; init; }

        [Range(0d, 100d)]
        [GreaterThanOrEqualToProperty(nameof(MinDarkEnergyPercent))]
        [PercentageWithProperties(new string[] { nameof(MaxDarkMatterPercent), nameof(MaxBaryonicMatterPercent) })]
        [DisplayName("Max Dark Energy Percent")]
        [Tooltip("Maximum amount of dark energy in the universe, as a percentage.")]
        public double MaxDarkEnergyPercent { get; init; }

        [Range(0d, 100d)]
        [LessThanOrEqualToProperty(nameof(MaxDarkMatterPercent))]
        [PercentageWithProperties(new string[] { nameof(MinDarkEnergyPercent), nameof(MinBaryonicMatterPercent) })]
        [DisplayName("Min Dark Matter Percent")]
        [Tooltip("Minimum amount of dark matter in the universe, as a percentage.")]
        public double MinDarkMatterPercent { get; init; }

        [Range(0d, 100d)]
        [GreaterThanOrEqualToProperty(nameof(MinDarkMatterPercent))]
        [PercentageWithProperties(new string[] { nameof(MaxDarkEnergyPercent), nameof(MaxBaryonicMatterPercent) })]
        [DisplayName("Max Dark Matter Percent")]
        [Tooltip("Maximum amount of dark matter in the universe, as a percentage.")]
        public double MaxDarkMatterPercent { get; init; }

        [Range(0d, 100d)]
        [LessThanOrEqualToProperty(nameof(MaxBaryonicMatterPercent))]
        [PercentageWithProperties(new string[] { nameof(MinDarkMatterPercent), nameof(MinDarkEnergyPercent) })]
        [DisplayName("Min Baryonic Matter Percent")]
        [Tooltip("Minimum amount of baryonic matter (normal matter) in the universe, as a percentage.")]
        public double MinBaryonicMatterPercent { get; init; }

        [Range(0d, 100d)]
        [GreaterThanOrEqualToProperty(nameof(MinBaryonicMatterPercent))]
        [PercentageWithProperties(new string[] { nameof(MaxDarkMatterPercent), nameof(MaxDarkEnergyPercent) })]
        [DisplayName("Max Baryonic Matter Percent")]
        [Tooltip("Maximum amount of baryonic matter (normal matter) in the universe, as a percentage.")]
        public double MaxBaryonicMatterPercent { get; init; }

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

        [DisplayName("Apply Gravitational Effects to Cosmic Web")]
        [Tooltip("Whether positions of nodes, filaments, sheets, and voids in the cosmic web should be adjusted due to gravity. Increases processing time.")]
        public bool ApplyGravitationalEffectsToCosmicWeb { get; init; }

        [DisplayName("Average Dimension (Calculated)")]
        [Tooltip("Average of the map X, Y, and Z dimensions.")]
        public float AverageDimension => CalculateAverageDim();

        [DisplayName("Baryonic Matter Node Merge Distance Threshold (Calculated)")]
        [Tooltip("The maximum distance at which nearby baryonic matter nodes will be merged.")]
        public float TopologyBaryonicMatterNodeMergeDistanceThreshold => ConfigConstants.BaryonicMatterNode.TopologyMergeDistanceThresholdFactor * this.AverageDimension;

        [DisplayName("Baryonic Matter Node Max Distance (Calculated)")]
        [Tooltip("The maximum distance allowed between baryonic matter nodes. After merging has been processed, for nodes closer than this value, the least intense one will be removed.")]
        public float TopologyBaryonicMatterNodeMinDistanceThreshold => this.TopologyBaryonicMatterNodeMergeDistanceThreshold * ConfigConstants.BaryonicMatterNode.TopologyMinDistanceThresholdFactor;

        [DisplayName("Dark Matter Node Merge Distance Threshold (Calculated)")]
        [Tooltip("The maximum distance at which nearby dark matter nodes will be merged.")]
        public float TopologyDarkMatterNodeMergeDistanceThreshold => ConfigConstants.DarkMatterNode.TopologyMergeDistanceThresholdFactor * this.AverageDimension;

        [DisplayName("Dark Matter Node Max Distance (Calculated)")]
        [Tooltip("The maximum distance allowed between dark matter nodes. After merging has been processed, for nodes closer than this value, the least intense one will be removed.")]
        public float TopologyDarkMatterNodeMinDistanceThreshold => this.TopologyDarkMatterNodeMergeDistanceThreshold * ConfigConstants.DarkMatterNode.TopologyMinDistanceThresholdFactor;

        [Required]
        [DirectoryExists]
        [DisplayName("Heightmap Folder")]
        [Tooltip("The folder that contains heightmap files.")]
        public string HeightmapFolder { get; init; }




        public BasicGenerationSettings()
        {
            this.DimensionX = ConfigConstants.DimensionX;
            this.DimensionY = ConfigConstants.DimensionY;
            this.DimensionZ = ConfigConstants.DimensionZ;
            this.MinDarkEnergyPercent = ConfigConstants.MinDarkEnergyPercent;
            this.MaxDarkEnergyPercent = ConfigConstants.MaxDarkEnergyPercent;
            this.MinDarkMatterPercent = ConfigConstants.MinDarkMatterPercent;
            this.MaxDarkMatterPercent = ConfigConstants.MaxDarkMatterPercent;
            this.MinBaryonicMatterPercent = ConfigConstants.MinBaryonicMatterPercent;
            this.MaxBaryonicMatterPercent = ConfigConstants.MaxBaryonicMatterPercent;
            this.MinUniverseAge = ConfigConstants.MinUniverseAge;
            this.MaxUniverseAge = ConfigConstants.MaxUniverseAge;
            this.ApplyGravitationalEffectsToCosmicWeb = ConfigConstants.ApplyGravitationalEffectsToCosmicWeb;
            this.HeightmapFolder = ConfigConstants.HeightmapFolder;
            this.HeightmapFile = ConfigConstants.HeightmapFile;
        }

        private float CalculateAverageDim()
        {
            return (DimensionX + DimensionY + DimensionZ) / 3;
        }
    }
}