using System.Collections.Concurrent;
using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    private readonly IntergalacticMediumGenerator _intergalacticMediumGenerator;
    private readonly BaryonicMatterFilamentGenerator _baryonicFilamentGenerator;
    private readonly DarkMatterFilamentGenerator _darkMatterFilamentGenerator;
    private readonly BaryonicMatterNodeGenerator _baryonicNodeGenerator;
    private readonly DarkMatterNodeGenerator _darkMatterNodeGenerator;
    private readonly BaryonicMatterVoidGenerator _baryonicVoidGenerator;
    private readonly DarkMatterVoidGenerator _darkMatterVoidGenerator;
    private readonly BaryonicMatterSheetGenerator _baryonicSheetGenerator;
    private readonly DarkMatterSheetGenerator _darkMatterSheetGenerator;



    public CosmicWebGenerator(GeneratorConfig config) : base(config)
    {
        _intergalacticMediumGenerator = new IntergalacticMediumGenerator(config);
        _baryonicFilamentGenerator = new BaryonicMatterFilamentGenerator(config);
        _darkMatterFilamentGenerator = new DarkMatterFilamentGenerator(config);
        _baryonicNodeGenerator = new BaryonicMatterNodeGenerator(config);
        _darkMatterNodeGenerator = new DarkMatterNodeGenerator(config);
        _baryonicVoidGenerator = new BaryonicMatterVoidGenerator(config);
        _darkMatterVoidGenerator = new DarkMatterVoidGenerator(config);
        _baryonicSheetGenerator = new BaryonicMatterSheetGenerator(config);
        _darkMatterSheetGenerator = new DarkMatterSheetGenerator(config);
    }

    public override CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb();     

        LoadCosmicTopology(cosmicWeb);
        GenerateBaryonicMatterNodes(cosmicWeb, context);
        GenerateDarkMatterNodes(cosmicWeb, context);

        //var intergalacticMediumContext = new IntergalacticMediumContext();
        //var imgTask = Task.Run(() => _intergalacticMediumGenerator.Generate(intergalacticMediumContext));

        //Task.WaitAll(imgTask);

        //cosmicWeb.IntergalacticMedium = imgTask.Result;

        PostProcess();

        return cosmicWeb;
    }


    private void LoadCosmicTopology(CosmicWeb cosmicWeb)
    {
        var heightMapImage = HeightmapUtil.LoadImage(config.Constants.HeightmapImageFile);

        if (config.Constants.GaussianSigma > 0f)
        {
            heightMapImage = HeightmapUtil.GaussianBlur(heightMapImage, config.Constants.GaussianSigma);
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


    private void GenerateBaryonicMatterNodes(CosmicWeb cosmicWeb, CosmicWebContext context)
    {
        var baryonicMatterNodeConfig = new NodeConfiguration()
        {
            NodeSeedMinDistanceThreshold = config.Calculated.TopologyBaryonicMatterNodeSeedMinDistanceThreshold,
            NodeDensityThresholdFactor = config.Constants.TopologyBaryonicMatterNodeDensityThresholdFactor,
            NodeGradientMagnitudeThresholdFactor = config.Constants.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor,
            NodeMaxPositionalOffset = config.Constants.TopologyBaryonicMatterNodeMaxPositionalOffset,
            NodeSeedMergeDistanceThreshold = config.Calculated.TopologyBaryonicMatterNodeSeedMergeDistanceThreshold
        };
        var baryonicMatterNodeCount = GetBaryonicMatterNodeCount(context, cosmicWeb.Topology.AverageIntensity);
        var baryonicMatterNodeSpatialGrid = InitializeSpatialGrid(cosmicWeb, baryonicMatterNodeConfig);
        var baryonicMatterNodeContext = new BaryonicMatterNodeContext(cosmicWeb)
        {
            SpatialGrid = baryonicMatterNodeSpatialGrid,
        };

        Parallel.For(0, baryonicMatterNodeCount, i =>
        {
            var baryonicNode = _baryonicNodeGenerator.Generate(baryonicMatterNodeContext);
            cosmicWeb.BaryonicNodes.Add(baryonicNode);
        });
    }
    private void GenerateDarkMatterNodes(CosmicWeb cosmicWeb, CosmicWebContext context)
    {
        var darkMatterNodeConfig = new NodeConfiguration()
        {
            NodeSeedMinDistanceThreshold = config.Calculated.TopologyDarkMatterNodeSeedMinDistanceThreshold,
            NodeDensityThresholdFactor = config.Constants.TopologyDarkMatterNodeDensityThresholdFactor,
            NodeGradientMagnitudeThresholdFactor = config.Constants.TopologyDarkMatterNodeGradientMagnitudeThresholdFactor,
            NodeMaxPositionalOffset = config.Constants.TopologyDarkMatterNodeMaxPositionalOffset,
            NodeSeedMergeDistanceThreshold = config.Calculated.TopologyDarkMatterNodeSeedMergeDistanceThreshold
        };
        var darkMatterNodeCount = GetDarkMatterNodeCount(context, cosmicWeb.Topology.AverageIntensity);
        var darkMatterNodeSpatialGrid = InitializeSpatialGrid(cosmicWeb, darkMatterNodeConfig);
        var darkMatterNodeContext = new DarkMatterNodeContext(cosmicWeb)
        {
            SpatialGrid = darkMatterNodeSpatialGrid,
        };

        Parallel.For(0, darkMatterNodeCount, i =>
        {
            var darkMatterNode = _darkMatterNodeGenerator.Generate(darkMatterNodeContext);
            cosmicWeb.DarkMatterNodes.Add(darkMatterNode);
        });
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


    private ConcurrentBag<NodeSeed> GenerateNodeSeeds(CosmicWebTopology topology, int numberToGenerate, NodeConfiguration nodeConfig)
    {
        var nodeSeeds = new ConcurrentBag<NodeSeed>();

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
            var randomNodeCount = config.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);
            seedsList = seedsList.OrderByDescending(seed => seed.Intensity).Take(randomNodeCount).ToList();
        }

        var targetNodeCount = config.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);

        while (seedsList.Count < targetNodeCount)
        {
            var potentialSeeds = GetPotentialNodeSeeds(seedsList, topology, nodeConfig);
            if (potentialSeeds.Count() == 0) break;

            var randomSeed = potentialSeeds[config.RandomGenerator.Next(potentialSeeds.Count)];
            seedsList.Add(randomSeed);
        }

        return new ConcurrentBag<NodeSeed>(seedsList);
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
        var baseCount = config.Constants.BaryonicMatterFilamentBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.BaryonicMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.BaryonicMatterFilamentMassFactor) * (context.Size * config.Constants.BaryonicMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (config.Constants.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.Constants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.Constants.BaryonicMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.Constants.BaryonicMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.Constants.BaryonicMatterFilamentDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.DarkMatterFilamentBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.DarkMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.DarkMatterFilamentMassFactor) * (context.Size * config.Constants.DarkMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (config.Constants.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.Constants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.Constants.DarkMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.Constants.DarkMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.Constants.DarkMatterFilamentDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.BaryonicMatterNodeBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.BaryonicMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.BaryonicMatterNodeMassFactor) * (context.Size * config.Constants.BaryonicMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (config.Constants.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.Constants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.Constants.BaryonicMatterNodeBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.Constants.BaryonicMatterNodeDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.Constants.BaryonicMatterNodeDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.DarkMatterNodeBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.DarkMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.DarkMatterNodeMassFactor) * (context.Size * config.Constants.DarkMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (config.Constants.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.Constants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.Constants.DarkMatterNodeDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.Constants.DarkMatterNodeBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.Constants.DarkMatterNodeDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.BaryonicMatterSheetBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.BaryonicMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.BaryonicMatterSheetMassFactor) * (context.Size * config.Constants.BaryonicMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (config.Constants.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.Constants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.Constants.BaryonicMatterSheetBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.Constants.BaryonicMatterSheetDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.Constants.BaryonicMatterSheetDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.DarkMatterSheetBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.DarkMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.DarkMatterSheetMassFactor) * (context.Size * config.Constants.DarkMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (config.Constants.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.Constants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.Constants.DarkMatterSheetDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.Constants.DarkMatterSheetBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.Constants.DarkMatterSheetDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.BaryonicMatterVoidBaseCount;

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

        baseCount += (int)(context.Age * config.Constants.BaryonicMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.BaryonicMatterVoidAgeFactor) * (context.Size * config.Constants.BaryonicMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.Constants.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.Constants.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.Constants.BaryonicMatterVoidBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / config.Constants.BaryonicMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.Constants.DarkMatterVoidBaseCount;

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
        baseCount += (int)(context.Age * config.Constants.DarkMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.Constants.DarkMatterVoidMassFactor) * (context.Size * config.Constants.DarkMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.Constants.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.Constants.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.Constants.DarkMatterVoidDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / config.Constants.DarkMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
}