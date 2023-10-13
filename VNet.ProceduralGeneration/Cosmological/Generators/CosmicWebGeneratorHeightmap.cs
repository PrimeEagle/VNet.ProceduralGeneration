using System.Drawing;
using System.Numerics;
using VNet.ImageProcessing;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Heightmap;

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
#pragma warning disable CA2208
#pragma warning disable CA1822
#pragma warning disable IDE0060
#pragma warning disable CA1416

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGenerator : GroupGeneratorBase<CosmicWeb, CosmicWebContext>
{
    private void GenerateCosmicWebByHeightmap(CosmicWebContext context, CosmicWeb self)
    {
        self.HeightmapTopology = LoadHeightmapTopology();
    }

    private CosmicWebHeightmapTopology LoadHeightmapTopology()
    {
        var heightMapImage = new Bitmap(BasicSettings.HeightmapFile);

        if (AdvancedSettings.Universe.GaussianSigma > 0f) heightMapImage = Enhancement.GaussianBlur(heightMapImage, AdvancedSettings.Universe.GaussianKernelSize, AdvancedSettings.Universe.GaussianSigma);

        var heightMap = HeightmapUtil.ImageToHeightmap(heightMapImage);

        var extrusionLevel = BasicSettings.DimensionZ / BasicSettings.DimensionX * heightMap.GetLength(0);
        var volumeMap = HeightmapUtil.ExtrudeHeightmapToVolumeMap(heightMap, (int) extrusionLevel);
        var gradientMap = HeightmapUtil.VolumeMapToGradientMap(volumeMap);
        var averageIntensity = HeightmapUtil.GetAverageIntensity(heightMapImage);
        var maxGradientMagnitude = gradientMap.Cast<Vector3>().Max(v => v.Length());

        var topology = new CosmicWebHeightmapTopology
        {
            AverageIntensity = averageIntensity,
            Heightmap = heightMap,
            VolumeMap = volumeMap,
            GradientMap = gradientMap,
            MaxGradientMagnitude = maxGradientMagnitude
        };

        return topology;
    }

    private SpatialGrid InitializeSpatialGrid(CosmicWeb cosmicWeb, SpatialGridContext context)
    {
        var volumeMap = cosmicWeb.HeightmapTopology.VolumeMap;
        var gradientMap = cosmicWeb.HeightmapTopology.GradientMap;
        var intensityThreshold = cosmicWeb.HeightmapTopology.AverageIntensity * context.NodeIntensityThresholdFactor;
        var gradientMagnitudeThreshold = cosmicWeb.HeightmapTopology.MaxGradientMagnitude * context.NodeGradientMagnitudeThresholdFactor;

        var spatialGrid = new SpatialGrid(volumeMap, (x, y, z) =>
        {
            var gradient = gradientMap[x, y, z];
            var intensity = volumeMap[x, y, z];
            return intensity > intensityThreshold && gradient.Length() > gradientMagnitudeThreshold ? SpatialGridCellStatus.Available : SpatialGridCellStatus.Unavailable;
        });

        return spatialGrid;
    }
}