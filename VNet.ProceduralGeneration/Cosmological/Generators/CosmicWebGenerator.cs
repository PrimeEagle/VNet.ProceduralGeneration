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

        baseCount += (int)(context.Age * advancedSettings.BaryonicMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterFilamentMassFactor) * (context.Size * advancedSettings.BaryonicMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.BaryonicMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.BaryonicMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.BaryonicMatterFilamentDarkEnergyPercentFactor));

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

        baseCount += (int)(context.Age * advancedSettings.DarkMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterFilamentMassFactor) * (context.Size * advancedSettings.DarkMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.DarkMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.DarkMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.DarkMatterFilamentDarkEnergyPercentFactor));

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

        baseCount += (int)(context.Age * advancedSettings.BaryonicMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterNodeMassFactor) * (context.Size * advancedSettings.BaryonicMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.BaryonicMatterNodeBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / advancedSettings.BaryonicMatterNodeDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.BaryonicMatterNodeDarkEnergyPercentFactor));

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

        baseCount += (int)(context.Age * advancedSettings.DarkMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterNodeMassFactor) * (context.Size * advancedSettings.DarkMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.DarkMatterNodeDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / advancedSettings.DarkMatterNodeBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.DarkMatterNodeDarkEnergyPercentFactor));

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

        baseCount += (int)(context.Age * advancedSettings.BaryonicMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterSheetMassFactor) * (context.Size * advancedSettings.BaryonicMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / advancedSettings.BaryonicMatterSheetBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / advancedSettings.BaryonicMatterSheetDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.BaryonicMatterSheetDarkEnergyPercentFactor));

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

        baseCount += (int)(context.Age * advancedSettings.DarkMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterSheetMassFactor) * (context.Size * advancedSettings.DarkMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (advancedSettings.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / advancedSettings.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / advancedSettings.DarkMatterSheetDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / advancedSettings.DarkMatterSheetBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / advancedSettings.DarkMatterSheetDarkEnergyPercentFactor));

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

        baseCount += (int)(context.Age * advancedSettings.BaryonicMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.BaryonicMatterVoidAgeFactor) * (context.Size * advancedSettings.BaryonicMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / advancedSettings.BaselineExpansionRate));
        baseCount = (int)(baseCount * (advancedSettings.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / advancedSettings.BaryonicMatterVoidBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / advancedSettings.BaryonicMatterVoidDarkEnergyPercentFactor));

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
        baseCount += (int)(context.Age * advancedSettings.DarkMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * advancedSettings.DarkMatterVoidMassFactor) * (context.Size * advancedSettings.DarkMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / advancedSettings.BaselineExpansionRate));
        baseCount = (int)(baseCount * (advancedSettings.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / advancedSettings.DarkMatterVoidDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / advancedSettings.DarkMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
}