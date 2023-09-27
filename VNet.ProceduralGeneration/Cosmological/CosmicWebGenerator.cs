using System.Collections.Concurrent;
using System.Numerics;

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

    private SpatialGrid _spatialGrid;


    public override CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb();

        var heightMapImage= HeightmapUtil.LoadImage(config.HeightmapImageFile);

        if (config.GaussianSigma > 0f)
        {
            heightMapImage = HeightmapUtil.GaussianBlur(heightMapImage, config.GaussianSigma);
        }

        var heightMap = HeightmapUtil.ImageToHeightmap(heightMapImage);
        var volumeMap = HeightmapUtil.ExtrudeHeightmapToVolumeMap(heightMap, 1);
        var gradientMap = HeightmapUtil.VolumeMapToGradientMap(volumeMap);
        var averageIntensity = HeightmapUtil.GetAverageIntensity(heightMapImage);
        var maxGradientMagnitude = gradientMap.Cast<Vector3>().Max(v => v.Length());

        cosmicWeb.Topology = new CosmicTopology()
        {
            AverageIntensity = averageIntensity,
            Heightmap = heightMap,
            VolumeMap = volumeMap,
            GradientMap = gradientMap,
            MaxGradientMagnitude = maxGradientMagnitude
        };

        var nodeSeeds = GenerateNodeSeeds(cosmicWeb.Topology, GetBaryonicMatterNodeCount(context, cosmicWeb.Topology.AverageIntensity));
        var filamentSeeds = GenerateFilamentSeeds(cosmicWeb.Topology);
        var sheetSeeds = GenerateSheetSeeds(cosmicWeb.Topology);
        var voidSeeds = GenerateVoidSeeds(cosmicWeb.Topology);

        Parallel.For(0, GetBaryonicMatterFilamentCount(context, averageIntensity), i =>
        {
            var baryonicFilament = _baryonicFilamentGenerator.Generate(new BaryonicMatterFilamentContext(cosmicWeb));
            cosmicWeb.BaryonicFilaments.Add(baryonicFilament);
        });

        Parallel.For(0, GetDarkMatterFilamentCount(context, averageIntensity), i =>
        {
            var darkMatterFilament = _darkMatterFilamentGenerator.Generate(new DarkMatterFilamentContext(cosmicWeb));
            cosmicWeb.DarkMatterFilaments.Add(darkMatterFilament);
        });

        Parallel.For(0, GetBaryonicMatterNodeCount(context, averageIntensity), i =>
        {
            var baryonicNode = _baryonicNodeGenerator.Generate(new BaryonicMatterNodeContext(cosmicWeb));
            cosmicWeb.BaryonicNodes.Add(baryonicNode);
        });

        Parallel.For(0, GetDarkMatterNodeCount(context, averageIntensity), i =>
        {
            var darkMatterNode = _darkMatterNodeGenerator.Generate(new DarkMatterNodeContext(cosmicWeb));
            cosmicWeb.DarkMatterNodes.Add(darkMatterNode);
        });

        Parallel.For(0, GetBaryonicMatterVoidCount(context, averageIntensity), i =>
        {
            var baryonicVoid = _baryonicVoidGenerator.Generate(new BaryonicMatterVoidContext(cosmicWeb));
            cosmicWeb.BaryonicVoids.Add(baryonicVoid);
        });

        Parallel.For(0, GetDarkMatterVoidCount(context, averageIntensity), i =>
        {
            var darkMatterVoid = _darkMatterVoidGenerator.Generate(new DarkMatterVoidContext(cosmicWeb));
            cosmicWeb.DarkMatterVoids.Add(darkMatterVoid);
        });

        Parallel.For(0, GetBaryonicMatterSheetCount(context, averageIntensity), i =>
        {
            var baryonicSheet = _baryonicSheetGenerator.Generate(new BaryonicMatterSheetContext(cosmicWeb));
            cosmicWeb.BaryonicSheets.Add(baryonicSheet);
        });

        Parallel.For(0, GetDarkMatterSheetCount(context, averageIntensity), i =>
        {
            var darkMatterSheet = _darkMatterSheetGenerator.Generate(new DarkMatterSheetContext(cosmicWeb));
            cosmicWeb.DarkMatterSheets.Add(darkMatterSheet);
        });

        var intergalacticMediumContext = new IntergalacticMediumContext();
        var imgTask = Task.Run(() => _intergalacticMediumGenerator.Generate(intergalacticMediumContext));

        Task.WaitAll(imgTask);

        cosmicWeb.IntergalacticMedium = imgTask.Result;

        PostProcess();

        return cosmicWeb;
    }

    private void PostProcess()
    {

    }

    private void IterativeRefinement(CosmicWeb cosmicWeb)
    {
        EnsureConnectivity(cosmicWeb);
        AdjustDensities(cosmicWeb);
        HandleCollisions(cosmicWeb);
    }

    private void EnsureConnectivity(CosmicWeb cosmicWeb)
    {
    }

    private void AdjustDensities(CosmicWeb cosmicWeb)
    {
    }

    private void HandleCollisions(CosmicWeb cosmicWeb)
    {
    }

    private ConcurrentBag<NodeSeed> GenerateNodeSeeds(CosmicTopology topology, int numberToGenerate)
    {
        var nodeSeeds = new ConcurrentBag<NodeSeed>();

        var densityThreshold = topology.AverageIntensity * config.TopologyBaryonicMatterNodeDensityThresholdFactor;
        var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * config.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor;

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
                    if (gradient.Length() > gradientMagnitudeThreshold)
                    {
                        var position = new Vector3(x, y, z) + GetRandomOffset(config.TopologyBaryonicMatterNodeMaxPositionalOffset);
                        nodeSeeds.Add(new NodeSeed(position, intensity));
                    }
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
                if (distance >= config.TopologyBaryonicMatterNodeSeedMergeDistanceThreshold) continue;

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
                if (distance >= config.TopologyBaryonicMatterNodeSeedMinDistanceThreshold) continue;

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
            // Assuming you can make a list of potential seeds that weren't added
            var potentialSeeds = GetPotentialSeeds(seedsList, topology);
            if (potentialSeeds.Count() == 0) break; // Exit if no more potential seeds

            var randomSeed = potentialSeeds[config.RandomGenerator.Next(potentialSeeds.Count)];
            seedsList.Add(randomSeed);
        }

        return new ConcurrentBag<NodeSeed>(seedsList);
    }

    private List<NodeSeed> GetPotentialSeeds(List<NodeSeed> currentSeeds, CosmicTopology topology)
    {
        var potentialSeeds = new List<NodeSeed>();
        var densityThreshold = topology.AverageIntensity * config.TopologyBaryonicMatterNodeDensityThresholdFactor;
        var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * config.TopologyBaryonicMatterNodeGradientMagnitudeThresholdFactor;

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

                    // Now check if it's too close to the already added seeds:
                    var potentialSeedPosition = new Vector3(x, y, z);
                    if (currentSeeds.Any(seed => Vector3.Distance(seed.Position, potentialSeedPosition) < config.TopologyBaryonicMatterNodeSeedMinDistanceThreshold))
                        continue;

                    potentialSeeds.Add(new NodeSeed(potentialSeedPosition, intensity));
                }
            }
        }

        return potentialSeeds;
    }

    private Vector3 GetRandomOffset(float maxOffset)
    {
        Random random = new Random();
        float offsetX = (float)(random.NextDouble() * 2 - 1) * maxOffset; // Random value between -maxOffset and maxOffset
        float offsetY = (float)(random.NextDouble() * 2 - 1) * maxOffset;
        float offsetZ = (float)(random.NextDouble() * 2 - 1) * maxOffset;

        return new Vector3(offsetX, offsetY, offsetZ);
    }


    private ConcurrentBag<FilamentSeed> GenerateFilamentSeeds(CosmicTopology topology)
    {
        var filamentSeeds = new ConcurrentBag<FilamentSeed>();

        return filamentSeeds;
    }

    private ConcurrentBag<SheetSeed> GenerateSheetSeeds(CosmicTopology topology)
    {
        var sheetSeeds = new ConcurrentBag<SheetSeed>();

        return sheetSeeds;
    }

    private ConcurrentBag<VoidSeed> GenerateVoidSeeds(CosmicTopology topology)
    {
        var voidSeeds = new ConcurrentBag<VoidSeed>();

        return voidSeeds;
    }



    private int GetBaryonicMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterFilamentBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterFilamentMassFactor) * (context.Size * config.BaryonicMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.BaryonicMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.BaryonicMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.BaryonicMatterFilamentDarkEnergyPercentFactor));

        return baseCount;
    }

    private int GetDarkMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterFilamentBaseCount;

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

        baseCount += (int)(context.Age * config.DarkMatterFilamentAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterFilamentMassFactor) * (context.Size * config.DarkMatterFilamentSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.DarkMatterFilamentDarkMatterPercentFactor);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.DarkMatterFilamentBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.DarkMatterFilamentDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetBaryonicMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterNodeBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterNodeMassFactor) * (context.Size * config.BaryonicMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.BaryonicMatterNodeBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.BaryonicMatterNodeDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.BaryonicMatterNodeDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetDarkMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterNodeBaseCount;

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

        baseCount += (int)(context.Age * config.DarkMatterNodeAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterNodeMassFactor) * (context.Size * config.DarkMatterNodeSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.DarkMatterNodeDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.DarkMatterNodeBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.DarkMatterNodeDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetBaryonicMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterVoidBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterVoidAgeFactor) * (context.Size * config.BaryonicMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.BaryonicMatterVoidBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / config.BaryonicMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetDarkMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterVoidBaseCount;

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
        baseCount += (int)(context.Age * config.DarkMatterVoidAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterVoidMassFactor) * (context.Size * config.DarkMatterVoidSizeFactor));
        baseCount = (int)(baseCount * (context.ExpansionRate / config.BaselineExpansionRate));
        baseCount = (int)(baseCount * (config.BaselineCosmicMicrowaveBackground/ context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.DarkMatterVoidDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / config.DarkMatterVoidDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetBaryonicMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.BaryonicMatterSheetBaseCount;

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

        baseCount += (int)(context.Age * config.BaryonicMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.BaryonicMatterSheetMassFactor) * (context.Size * config.BaryonicMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / config.BaryonicMatterSheetBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / config.BaryonicMatterSheetDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.BaryonicMatterSheetDarkEnergyPercentFactor));

        return baseCount;
    }
    
    private int GetDarkMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = config.DarkMatterSheetBaseCount;

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

        baseCount += (int)(context.Age * config.DarkMatterSheetAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * config.DarkMatterSheetMassFactor) * (context.Size * config.DarkMatterSheetSizeFactor));
        baseCount = (int)(baseCount * (config.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / config.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / config.DarkMatterSheetDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / config.DarkMatterSheetBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / config.DarkMatterSheetDarkEnergyPercentFactor));

        return baseCount;
    }
    
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
}