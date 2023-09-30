using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    public CosmicWebGenerator() : base(ParallelismLevel.Level0)
    {
    }

    public async override Task<CosmicWeb> Generate(CosmicWebContext context)
    {
        return await ExecuteWithConcurrencyControlAsync(() => GenerateCosmicWeb(context));
    }
    private async Task<CosmicWeb> GenerateCosmicWeb(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb();     

        LoadCosmicTopology(cosmicWeb);
        cosmicWeb.BaryonicMatterNodes = await GenerateBaryonicMatterNodes(cosmicWeb, context);
        cosmicWeb.DarkMatterNodes = await GenerateDarkMatterNodes(cosmicWeb, context);

        PostProcess();

        return cosmicWeb;
    }


    private void LoadCosmicTopology(CosmicWeb cosmicWeb)
    {
        var heightMapImage = HeightmapUtil.LoadImage(basicSettings.HeightmapImageFile);

        if (advancedSettings.GaussianSigma > 0f)
        {
            heightMapImage = HeightmapUtil.GaussianBlur(heightMapImage, advancedSettings.GaussianSigma);
        }

        var heightMap = HeightmapUtil.ImageToHeightmap(heightMapImage);
        var volumeMap = HeightmapUtil.ExtrudeHeightmapToVolumeMap(heightMap, 1);
        var gradientMap = HeightmapUtil.VolumeMapToGradientMap(volumeMap);
        var averageIntensity = HeightmapUtil.GetAverageIntensity(heightMapImage);
        var maxGradientMagnitude = gradientMap.Cast<Vector3>().Max(v => v.Length());

        cosmicWeb.Topology = new CosmicWebTopology()
        {
            AverageIntensity = averageIntensity,
            Heightmap = heightMap,
            VolumeMap = volumeMap,
            GradientMap = gradientMap,
            MaxGradientMagnitude = maxGradientMagnitude
        };
    }

    private async Task<List<BaryonicMatterNode>> GenerateBaryonicMatterNodes(CosmicWeb cosmicWeb, CosmicWebContext context)
    {
        var baryonicMatterNodeConfig = new NodeConfiguration()
        {
            NodeSeedMinDistanceThreshold = basicSettings.TopologyBaryonicMatterNodeMinDistanceThreshold,
            NodeDensityThresholdFactor = advancedSettings.TopologyBaryonicMatterNodeDensityThresholdFactor,
            NodeGradientMagnitudeThresholdFactor = advancedSettings.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor,
            NodeMaxPositionalOffset = advancedSettings.TopologyBaryonicMatterNodeMaxPositionalOffset,
            NodeSeedMergeDistanceThreshold = basicSettings.TopologyBaryonicMatterNodeMergeDistanceThreshold
        };
        var baryonicMatterNodeCount = GetBaryonicMatterNodeCount(context, cosmicWeb.Topology.AverageIntensity);
        var baryonicMatterNodeSpatialGrid = InitializeSpatialGrid(cosmicWeb, baryonicMatterNodeConfig);
        var baryonicMatterNodeContext = new BaryonicMatterNodeContext(cosmicWeb)
        {
            SpatialGrid = baryonicMatterNodeSpatialGrid,
        };

        var tasks = new List<Task<BaryonicMatterNode>>();
        for (int i = 0; i < baryonicMatterNodeCount; i++)
        {
            var _baryonicMatterNodeGenerator = new BaryonicMatterNodeGenerator();
            tasks.Add(_baryonicMatterNodeGenerator.Generate(baryonicMatterNodeContext));
        }
        var results = await Task.WhenAll(tasks);

        return results.ToList();
    }

    private async Task<List<DarkMatterNode>> GenerateDarkMatterNodes(CosmicWeb cosmicWeb, CosmicWebContext context)
    {
        var darkMatterNodeConfig = new NodeConfiguration()
        {
            NodeSeedMinDistanceThreshold = basicSettings.TopologyDarkMatterNodeMinDistanceThreshold,
            NodeDensityThresholdFactor = advancedSettings.TopologyDarkMatterNodeDensityThresholdFactor,
            NodeGradientMagnitudeThresholdFactor = advancedSettings.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor,
            NodeMaxPositionalOffset = advancedSettings.TopologyDarkMatterNodeMaxPositionalOffset,
            NodeSeedMergeDistanceThreshold = basicSettings.TopologyDarkMatterNodeMergeDistanceThreshold
        };
        var darkMatterNodeCount = GetDarkMatterNodeCount(context, cosmicWeb.Topology.AverageIntensity);
        var darkMatterNodeSpatialGrid = InitializeSpatialGrid(cosmicWeb, darkMatterNodeConfig);
        var darkMatterNodeContext = new DarkMatterNodeContext(cosmicWeb)
        {
            SpatialGrid = darkMatterNodeSpatialGrid,
        };

        var tasks = new List<Task<DarkMatterNode>>();
        for (int i = 0; i < darkMatterNodeCount; i++)
        {
            var _darkMatterNodeGenerator = new DarkMatterNodeGenerator();
            tasks.Add(_darkMatterNodeGenerator.Generate(darkMatterNodeContext));
        }
        var results = await Task.WhenAll(tasks);

        return results.ToList();
    }

    private SpatialGrid InitializeSpatialGrid(CosmicWeb cosmicWeb, NodeConfiguration nodeConfig)
    {
        var volumeMap = cosmicWeb.Topology.VolumeMap;
        var densityThreshold = cosmicWeb.Topology.AverageIntensity * nodeConfig.NodeDensityThresholdFactor;

        var spatialGrid = new SpatialGrid(volumeMap, (x, y, z) =>
        {
            var intensity = volumeMap[x, y, z];
            return intensity > densityThreshold ? SpatialGridCellStatus.Available : SpatialGridCellStatus.Unavailable;
        });

        return spatialGrid;
    }


    private void PostProcess()
    {
    }


    private List<NodeSeed> GenerateNodeSeeds(CosmicWebTopology topology, int numberToGenerate, NodeConfiguration nodeConfig)
    {
        var nodeSeeds = new List<NodeSeed>();

        var densityThreshold = topology.AverageIntensity * nodeConfig.NodeDensityThresholdFactor;
        var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * nodeConfig.NodeGradientMagnitudeThresholdFactor;

        var width = topology.VolumeMap.GetLength(0);
        var height = topology.VolumeMap.GetLength(1);
        var depth = topology.VolumeMap.GetLength(2);

        Parallel.For(0, width, x =>
        {
            for (var y = 0; y < height; y++)
            {
                for (var z = 0; z < depth; z++)
                {
                    var intensity = topology.VolumeMap[x, y, z];
                    if (intensity <= densityThreshold) continue;

                    var gradient = topology.GradientMap[x, y, z];
                    if (gradient.Length() <= gradientMagnitudeThreshold) continue;

                    var position = new Vector3(x, y, z) + Util.GetRandomOffset(nodeConfig.NodeMaxPositionalOffset);
                    nodeSeeds.Add(new NodeSeed(position, intensity));
                }
            }
        });

        // Merging nearby seeds
        var seedsList = nodeSeeds.ToList();
        for (var i = 0; i < seedsList.Count; i++)
        {
            for (var j = i + 1; j < seedsList.Count; j++)
            {
                var distance = Vector3.Distance(seedsList[i].Position, seedsList[j].Position);
                if (distance >= nodeConfig.NodeSeedMergeDistanceThreshold) continue;

                var mergedPosition = (seedsList[i].Position + seedsList[j].Position) / 2;
                var mergedIntensity = (seedsList[i].Intensity + seedsList[j].Intensity) / 2;

                seedsList[i] = new NodeSeed(mergedPosition, mergedIntensity);
                seedsList.RemoveAt(j);
                j--;
            }
        }

        // Ensuring minimum distance
        for (var i = 0; i < seedsList.Count; i++)
        {
            for (var j = i + 1; j < seedsList.Count; j++)
            {
                var distance = Vector3.Distance(seedsList[i].Position, seedsList[j].Position);
                if (distance >= nodeConfig.NodeSeedMinDistanceThreshold) continue;

                if (seedsList[i].Intensity > seedsList[j].Intensity)
                {
                    seedsList.RemoveAt(j);
                    j--;
                }
                else
                {
                    seedsList.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }

        var minAllowedNodes = (int)(numberToGenerate * 0.9);
        var maxAllowedNodes = (int)(numberToGenerate * 1.1);

        if (seedsList.Count > maxAllowedNodes)
        {
            var randomNodeCount = advancedSettings.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);
            seedsList = seedsList.OrderByDescending(seed => seed.Intensity).Take(randomNodeCount).ToList();
        }

        var targetNodeCount = advancedSettings.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);

        while (seedsList.Count < targetNodeCount)
        {
            var potentialSeeds = GetPotentialNodeSeeds(seedsList, topology, nodeConfig);
            if (potentialSeeds.Count() == 0) break;

            var randomSeed = potentialSeeds[advancedSettings.RandomGenerator.Next(potentialSeeds.Count)];
            seedsList.Add(randomSeed);
        }

        return new List<NodeSeed>(seedsList);
    }
    private List<NodeSeed> GetPotentialNodeSeeds(IReadOnlyCollection<NodeSeed> currentSeeds, CosmicWebTopology topology, NodeConfiguration nodeConfig)
    {
        var potentialSeeds = new List<NodeSeed>();
        var densityThreshold = topology.AverageIntensity * nodeConfig.NodeDensityThresholdFactor;
        var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * nodeConfig.NodeGradientMagnitudeThresholdFactor;

        var width = topology.VolumeMap.GetLength(0);
        var height = topology.VolumeMap.GetLength(1);
        var depth = topology.VolumeMap.GetLength(2);

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                for (var z = 0; z < depth; z++)
                {
                    var intensity = topology.VolumeMap[x, y, z];
                    if (intensity <= densityThreshold) continue;

                    var gradient = topology.GradientMap[x, y, z];
                    if (gradient.Length() <= gradientMagnitudeThreshold) continue;

                    var potentialSeedPosition = new Vector3(x, y, z);
                    if (currentSeeds.Any(seed => Vector3.Distance(seed.Position, potentialSeedPosition) < nodeConfig.NodeSeedMinDistanceThreshold))
                        continue;

                    potentialSeeds.Add(new NodeSeed(potentialSeedPosition, intensity));
                }
            }
        }

        return potentialSeeds;
    }


    private int GetBaryonicMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.BaryonicMatterFilamentBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 200;
                break;
            case CurvatureType.Spherical:
                baseCount += 100;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 100;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.BaryonicMatterFilament.BaryonicMatterFilamentCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterFilament.BaryonicMatterFilamentCountMassFactor) * (context.Size * advancedSettings.BaryonicMatterFilament.BaryonicMatterFilamentCountSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.BaryonicMatterFilament.BaryonicMatterFilamentCountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.BaryonicMatterFilament.BaryonicMatterFilamentCountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.BaryonicMatterFilament.BaryonicMatterFilamentCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.DarkMatterFilamentBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 250;
                break;
            case CurvatureType.Spherical:
                baseCount += 150;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 150;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.DarkMatterFilament.DarkMatterFilamentCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterFilament.DarkMatterFilamentCountMassFactor) * (context.Size * advancedSettings.DarkMatterFilament.DarkMatterFilamentCountSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.DarkMatterFilament.DarkMatterFilamentCountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.DarkMatterFilament.DarkMatterFilamentCountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.DarkMatterFilament.DarkMatterFilamentCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.BaryonicMatterNodeBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 50;
                break;
            case CurvatureType.Spherical:
                baseCount += 30;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 20;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.BaryonicMatterNode.BaryonicMatterNodeCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterNode.BaryonicMatterNodeCountMassFactor) * (context.Size * advancedSettings.BaryonicMatterNode.BaryonicMatterNodeCountSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.BaryonicMatterNode.BaryonicMatterNodeCountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / advancedSettings.BaryonicMatterNode.BaryonicMatterNodeCountDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.BaryonicMatterNode.BaryonicMatterNodeCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.DarkMatterNodeBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 60;
                break;
            case CurvatureType.Spherical:
                baseCount += 40;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 30;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.DarkMatterNode.DarkMatterNodeCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterNode.DarkMatterNodeCountMassFactor) * (context.Size * advancedSettings.DarkMatterNode.DarkMatterNodeCountSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.DarkMatterNode.DarkMatterNodeCountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / advancedSettings.DarkMatterNode.DarkMatterNodeCountBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.DarkMatterNode.DarkMatterNodeCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.BaryonicMatterSheetBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 40;
                break;
            case CurvatureType.Spherical:
                baseCount += 20;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 20;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.BaryonicMatterSheet.BaryonicMatterSheetCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterSheet.BaryonicMatterSheetCountMassFactor) * (context.Size * advancedSettings.BaryonicMatterSheet.BaryonicMatterSheetCountSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.BaryonicMatterSheet.BaryonicMatterSheetCountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / advancedSettings.BaryonicMatterSheet.BaryonicMatterSheetCountDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.BaryonicMatterSheet.BaryonicMatterSheetCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.DarkMatterSheetBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 50;
                break;
            case CurvatureType.Spherical:
                baseCount += 30;
                break;
            case CurvatureType.Hyperbolic:
                baseCount -= 30;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.DarkMatterSheet.DarkMatterSheetCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterSheet.DarkMatterSheetCountMassFactor) * (context.Size * advancedSettings.DarkMatterSheet.DarkMatterSheetCountSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.DarkMatterSheet.DarkMatterSheetCountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / advancedSettings.DarkMatterSheet.DarkMatterSheetCountBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.DarkMatterSheet.DarkMatterSheetCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.BaryonicMatterVoidBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 100;
                break;
            case CurvatureType.Spherical:
                baseCount -= 50;
                break;
            case CurvatureType.Hyperbolic:
                baseCount += 50;
                break;
        }

        baseCount += (int)(context.Age * 1e-9 * advancedSettings.BaryonicMatterVoid.BaryonicMatterVoidCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterVoid.BaryonicMatterVoidCountAgeFactor) * (context.Size * advancedSettings.BaryonicMatterVoid.BaryonicMatterVoidCountSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / advancedSettings.BaselineExpansionRate));
        baseCount = (int)(baseCount * (advancedSettings.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / advancedSettings.BaryonicMatterVoid.BaryonicMatterVoidCountBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / advancedSettings.BaryonicMatterVoid.BaryonicMatterVoidCountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = basicSettings.DarkMatterVoidBaseCount;

        switch (context.Curvature)
        {
            case CurvatureType.Flat:
                baseCount += 120;
                break;
            case CurvatureType.Spherical:
                baseCount -= 60;
                break;
            case CurvatureType.Hyperbolic:
                baseCount += 60;
                break;
        }
        baseCount += (int)(context.Age * 1e-9 * advancedSettings.DarkMatterVoid.DarkMatterVoidCountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterVoid.DarkMatterVoidCountMassFactor) * (context.Size * advancedSettings.DarkMatterVoid.DarkMatterVoidCountSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / advancedSettings.BaselineExpansionRate));
        baseCount = (int)(baseCount * (advancedSettings.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / advancedSettings.DarkMatterVoid.DarkMatterVoidCountDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / advancedSettings.DarkMatterVoid.DarkMatterVoidCountDarkEnergyPercentFactor));

        return baseCount;
    }
}