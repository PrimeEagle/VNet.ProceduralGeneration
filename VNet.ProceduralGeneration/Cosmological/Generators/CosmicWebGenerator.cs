using System.Drawing;
using System.Numerics;
using VNet.ImageProcessing;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Heightmap;
using VNet.System.Events;
#pragma warning disable IDE0060
#pragma warning disable CA1416

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicWebGenerator : ContainerGeneratorBase<CosmicWeb, CosmicWebContext>
{
    public CosmicWebGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        Enabled = ObjectToggles.CosmicWebEnabled;
    }

    protected override async Task<CosmicWeb> GenerateSelf(CosmicWebContext context, CosmicWeb self)
    {
        switch (AdvancedSettings.CosmicWeb.CosmicWebGenerationMethod)
        {
            case CosmicWebGenerationMethod.Heightmap:
                self.HeightmapTopology = LoadCosmicTopology();
                break;
            case CosmicWebGenerationMethod.Random:
                break;
            case CosmicWebGenerationMethod.Evolution:
                break;
            case CosmicWebGenerationMethod.None:
            default:
                throw new ArgumentOutOfRangeException();
        }

        return self;
    }

    protected override async Task GenerateChildren(CosmicWebContext context, CosmicWeb self)
    {
        var baryonicMatterNodeCount = GetBaryonicMatterNodeCount(context, self.HeightmapTopology.AverageIntensity);
        self.BaryonicMatterNodes = await GenerateBaryonicMatterNodes(self, baryonicMatterNodeCount);
        ApplyZOffsetsToBaryonicMatterNodes(self.BaryonicMatterNodes);
        SmoothZCoordinatesOfBaryonicMatterNodes(self.BaryonicMatterNodes);
        MergeBaryonicMatterNodes(self.BaryonicMatterNodes);
        ReduceBaryonicMatterNodes(self.BaryonicMatterNodes);
        RebalanceBaryonicMatterNodeCounts(self.BaryonicMatterNodes, self, baryonicMatterNodeCount);

        var darkMatterNodeCount = GetDarkMatterNodeCount(context, self.HeightmapTopology.AverageIntensity);
        self.DarkMatterNodes = await GenerateDarkMatterNodes(self, darkMatterNodeCount);
        ApplyZOffsetsToDarkMatterNodes(self.DarkMatterNodes);
        SmoothZCoordinatesOfDarkMatterNodes(self.DarkMatterNodes);
        MergeDarkMatterNodes(self.DarkMatterNodes);
        ReduceDarkMatterNodes(self.DarkMatterNodes);
        RebalanceDarkMatterNodeCounts(self.DarkMatterNodes, self, darkMatterNodeCount);
    }

    protected override async Task PostProcess(CosmicWebContext context, CosmicWeb self)
    {
        ApplyGravitationalEffects(self);
    }

    private void ApplyGravitationalEffects(CosmicWeb self)
    {
        if (!BasicSettings.ApplyGravitationalEffectsToCosmicWeb) return;
    }

    private CosmicWebHeightmapTopology LoadCosmicTopology()
    {
        var heightMapImage = new Bitmap(BasicSettings.HeightmapFile);

        if (AdvancedSettings.Universe.GaussianSigma > 0f)
        {
            heightMapImage = Enhancement.GaussianBlur(heightMapImage, AdvancedSettings.Universe.GaussianKernelSize, AdvancedSettings.Universe.GaussianSigma);
        }

        var heightMap = HeightmapUtil.ImageToHeightmap(heightMapImage);

        var extrusionLevel = (BasicSettings.DimensionZ / BasicSettings.DimensionX) * heightMap.GetLength(0);
        var volumeMap = HeightmapUtil.ExtrudeHeightmapToVolumeMap(heightMap, (int)extrusionLevel);
        var gradientMap = HeightmapUtil.VolumeMapToGradientMap(volumeMap);
        var averageIntensity = HeightmapUtil.GetAverageIntensity(heightMapImage);
        var maxGradientMagnitude = gradientMap.Cast<Vector3>().Max(v => v.Length());

        var topology = new CosmicWebHeightmapTopology()
        {
            AverageIntensity = averageIntensity,
            Heightmap = heightMap,
            VolumeMap = volumeMap,
            GradientMap = gradientMap,
            MaxGradientMagnitude = maxGradientMagnitude
        };

        return topology;
    }

    private async Task<List<BaryonicMatterNode>> GenerateBaryonicMatterNodes(CosmicWeb cosmicWeb, int numberToGenerate)
    {
        var spatialGridContext = new SpatialGridContext()
        {
            NodeIntensityThresholdFactor = AdvancedSettings.BaryonicMatterNode.TopologyIntensityThresholdFactor,
            NodeGradientMagnitudeThresholdFactor = AdvancedSettings.BaryonicMatterNode.TopologyGradientMagnitudeThresholdFactor
        };

        var baryonicMatterNodeSpatialGrid = InitializeSpatialGrid(cosmicWeb, spatialGridContext);
        var baryonicMatterNodeContext = new BaryonicMatterNodeContext(cosmicWeb)
        {
            SpatialGrid = baryonicMatterNodeSpatialGrid,
        };

        var tasks = new List<Task<BaryonicMatterNode>>();
        for (var i = 0; i < numberToGenerate; i++)
        {
            var baryonicMatterNodeGenerator = new BaryonicMatterNodeGenerator(this.EventAggregator);
            tasks.Add(baryonicMatterNodeGenerator.Generate(baryonicMatterNodeContext, cosmicWeb));
        }
        var results = await Task.WhenAll(tasks);

        return results.ToList();
    }

    private async Task<List<DarkMatterNode>> GenerateDarkMatterNodes(CosmicWeb cosmicWeb, int numberToGenerate)
    {
        var spatialGridContext = new SpatialGridContext()
        {
            NodeIntensityThresholdFactor = AdvancedSettings.DarkMatterNode.TopologyIntensityThresholdFactor,
            NodeGradientMagnitudeThresholdFactor = AdvancedSettings.DarkMatterNode.TopologyGradientMagnitudeThresholdFactor
        };

        var darkMatterNodeSpatialGrid = InitializeSpatialGrid(cosmicWeb, spatialGridContext);
        var darkMatterNodeContext = new DarkMatterNodeContext(cosmicWeb)
        {
            SpatialGrid = darkMatterNodeSpatialGrid,
        };

        var tasks = new List<Task<DarkMatterNode>>();
        for (var i = 0; i < numberToGenerate; i++)
        {
            var darkMatterNodeGenerator = new DarkMatterNodeGenerator(this.EventAggregator, ParallelismLevel.Level1);
            tasks.Add(darkMatterNodeGenerator.Generate(darkMatterNodeContext, cosmicWeb));
        }
        var results = await Task.WhenAll(tasks);

        return results.ToList();
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

    private void MergeBaryonicMatterNodes(IList<BaryonicMatterNode> nodes)
    {
        for (var i = 0; i < nodes.Count; i++)
        {
            for (var j = i + 1; j < nodes.Count; j++)
            {
                var distance = Vector3.Distance(nodes[i].Position, nodes[j].Position);
                if (distance >= BasicSettings.TopologyBaryonicMatterNodeMergeDistanceThreshold) continue;

                var mergedPosition = (nodes[i].Position + nodes[j].Position) / 2;
                var mergedIntensity = (nodes[i].AbsoluteMagnitude + nodes[j].AbsoluteMagnitude) / 2;

                nodes[i] = new BaryonicMatterNode
                {
                    Position = mergedPosition,
                    Luminosity = mergedIntensity
                };
                nodes.RemoveAt(j);
                j--;
            }
        }
    }

    private void ReduceBaryonicMatterNodes(IList<BaryonicMatterNode> nodes)
    {
        for (var i = 0; i < nodes.Count; i++)
        {
            for (var j = i + 1; j < nodes.Count; j++)
            {
                var distance = Vector3.Distance(nodes[i].Position, nodes[j].Position);
                if (distance >= BasicSettings.TopologyBaryonicMatterNodeMinDistanceThreshold) continue;

                if (nodes[i].AbsoluteMagnitude > nodes[j].AbsoluteMagnitude)
                {
                    nodes.RemoveAt(j);
                    j--;
                }
                else
                {
                    nodes.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
    }

    private void RebalanceBaryonicMatterNodeCounts(IList<BaryonicMatterNode> nodes, CosmicWeb cosmicWeb, int numberToGenerate)
    {
        var minAllowedNodes = (int)(numberToGenerate * (1 - AdvancedSettings.BaryonicMatterNode.CountTolerancePercentage / 100));
        var maxAllowedNodes = (int)(numberToGenerate * (1 + AdvancedSettings.BaryonicMatterNode.CountTolerancePercentage / 100));

        if (nodes.Count > maxAllowedNodes)
        {
            var randomNodeCount = AdvancedSettings.CosmicWeb.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);
            nodes = nodes.OrderByDescending(node => node.AbsoluteMagnitude).Take(randomNodeCount).ToList();
        }

        var targetNodeCount = AdvancedSettings.CosmicWeb.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);

        while (nodes.Count < targetNodeCount)
        {
            var potentialNodes = GetPotentialBaryonicMatterNodes(nodes, cosmicWeb.HeightmapTopology);
            if (potentialNodes.Count == 0) break;

            var randomSeed = potentialNodes[AdvancedSettings.CosmicWeb.RandomGenerator.Next(potentialNodes.Count)];
            nodes.Add(randomSeed);
        }
    }

    private void MergeDarkMatterNodes(IList<DarkMatterNode> nodes)
    {
        for (var i = 0; i < nodes.Count; i++)
        {
            for (var j = i + 1; j < nodes.Count; j++)
            {
                var distance = Vector3.Distance(nodes[i].Position, nodes[j].Position);
                if (distance >= BasicSettings.TopologyDarkMatterNodeMergeDistanceThreshold) continue;

                var mergedPosition = (nodes[i].Position + nodes[j].Position) / 2;
                var mergedIntensity = (nodes[i].Luminosity + nodes[j].Luminosity) / 2;

                nodes[i] = new DarkMatterNode
                {
                    Position = mergedPosition,
                    Luminosity = mergedIntensity
                };
                nodes.RemoveAt(j);
                j--;
            }
        }
    }

    private void ReduceDarkMatterNodes(IList<DarkMatterNode> nodes)
    {
        for (var i = 0; i < nodes.Count; i++)
        {
            for (var j = i + 1; j < nodes.Count; j++)
            {
                var distance = Vector3.Distance(nodes[i].Position, nodes[j].Position);
                if (distance >= BasicSettings.TopologyBaryonicMatterNodeMinDistanceThreshold) continue;

                if (nodes[i].Luminosity > nodes[j].Luminosity)
                {
                    nodes.RemoveAt(j);
                    j--;
                }
                else
                {
                    nodes.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
    }

    private void RebalanceDarkMatterNodeCounts(IList<DarkMatterNode> nodes, CosmicWeb cosmicWeb, int numberToGenerate)
    {
        var minAllowedNodes = (int)(numberToGenerate * (1 - AdvancedSettings.DarkMatterNode.CountTolerancePercentage / 100));
        var maxAllowedNodes = (int)(numberToGenerate * (1 + AdvancedSettings.DarkMatterNode.CountTolerancePercentage / 100));

        if (nodes.Count > maxAllowedNodes)
        {
            var randomNodeCount = AdvancedSettings.CosmicWeb.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);
            nodes = nodes.OrderByDescending(node => node.Luminosity).Take(randomNodeCount).ToList();
        }

        var targetNodeCount = AdvancedSettings.CosmicWeb.RandomGenerator.Next(minAllowedNodes, maxAllowedNodes + 1);

        while (nodes.Count < targetNodeCount)
        {
            var potentialNodes = GetPotentialDarkMatterNodes(nodes, cosmicWeb.HeightmapTopology);
            if (potentialNodes.Count == 0) break;

            var randomSeed = potentialNodes[AdvancedSettings.CosmicWeb.RandomGenerator.Next(potentialNodes.Count)];
            nodes.Add(randomSeed);
        }
    }

    private void ApplyZOffsetsToBaryonicMatterNodes(IList<BaryonicMatterNode> nodes)
    {
    }

    private void SmoothZCoordinatesOfBaryonicMatterNodes(IList<BaryonicMatterNode> nodes)
    {
    }

    private void ApplyZOffsetsToDarkMatterNodes(IList<DarkMatterNode> nodes)
    {
    }

    private void SmoothZCoordinatesOfDarkMatterNodes(IList<DarkMatterNode> nodes)
    {
    }

    private List<BaryonicMatterNode> GetPotentialBaryonicMatterNodes(IList<BaryonicMatterNode> nodes, CosmicWebHeightmapTopology topology)
    {
        var potentialNodes = new List<BaryonicMatterNode>();
        var intensityThreshold = topology.AverageIntensity * AdvancedSettings.BaryonicMatterNode.TopologyIntensityThresholdFactor;
        var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * AdvancedSettings.BaryonicMatterNode.TopologyGradientMagnitudeThresholdFactor;

        var width = topology.VolumeMap.GetLength(0);
        var height = topology.VolumeMap.GetLength(1);
        var depth = topology.VolumeMap.GetLength(2);

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                for (var z = 0; z < depth; z++)
                {
                    var luminosity = topology.VolumeMap[x, y, z];
                    if (luminosity <= intensityThreshold) continue;

                    var gradient = topology.GradientMap[x, y, z];
                    if (gradient.Length() <= gradientMagnitudeThreshold) continue;

                    var potentialNodePosition = new Vector3(x, y, z);
                    if (nodes.Any(seed => Vector3.Distance(seed.Position, potentialNodePosition) < BasicSettings.TopologyBaryonicMatterNodeMinDistanceThreshold))
                        continue;

                    var newNode = new BaryonicMatterNode()
                    {
                        Position = potentialNodePosition,
                        Luminosity = luminosity
                    };
                    potentialNodes.Add(newNode);
                }
            }
        }

        return potentialNodes;
    }

    private List<DarkMatterNode> GetPotentialDarkMatterNodes(IList<DarkMatterNode> nodes, CosmicWebHeightmapTopology topology)
    {
        var potentialNodes = new List<DarkMatterNode>();
        var intensityThreshold = topology.AverageIntensity * AdvancedSettings.DarkMatterNode.TopologyIntensityThresholdFactor;
        var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * AdvancedSettings.DarkMatterNode.TopologyGradientMagnitudeThresholdFactor;

        var width = topology.VolumeMap.GetLength(0);
        var height = topology.VolumeMap.GetLength(1);
        var depth = topology.VolumeMap.GetLength(2);

        for (var x = 0; x < width; x++)
        {
            for (var y = 0; y < height; y++)
            {
                for (var z = 0; z < depth; z++)
                {
                    var magnitude = topology.VolumeMap[x, y, z];
                    if (magnitude <= intensityThreshold) continue;

                    var gradient = topology.GradientMap[x, y, z];
                    if (gradient.Length() <= gradientMagnitudeThreshold) continue;

                    var potentialNodePosition = new Vector3(x, y, z);
                    if (nodes.Any(seed => Vector3.Distance(seed.Position, potentialNodePosition) < BasicSettings.TopologyDarkMatterNodeMinDistanceThreshold))
                        continue;

                    var newNode = new DarkMatterNode()
                    {
                        Position = potentialNodePosition,
                        Luminosity = magnitude
                    };
                    potentialNodes.Add(newNode);
                }
            }
        }

        return potentialNodes;
    }


    private int GetBaryonicMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.BaryonicMatterFilamentBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.BaryonicMatterFilament.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.BaryonicMatterFilament.CountMassFactor) * (context.Size * AdvancedSettings.BaryonicMatterFilament.CountSizeFactor));
        //baseCount = (int)(baseCount * (AdvancedSettings.Universe.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / AdvancedSettings.BaryonicMatterFilament.CountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * context.DarkMatterPercent / AdvancedSettings.BaryonicMatterFilament.CountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / AdvancedSettings.BaryonicMatterFilament.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterFilamentCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.DarkMatterFilamentBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.DarkMatterFilament.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.DarkMatterFilament.CountMassFactor) * (context.Size * AdvancedSettings.DarkMatterFilament.CountSizeFactor));
        //baseCount = (int)(baseCount * (AdvancedSettings.Universe.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / AdvancedSettings.DarkMatterFilament.CountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / AdvancedSettings.DarkMatterFilament.CountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / AdvancedSettings.DarkMatterFilament.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.BaryonicMatterNodeBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.BaryonicMatterNode.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.BaryonicMatterNode.CountMassFactor) * (context.Size * AdvancedSettings.BaryonicMatterNode.CountSizeFactor));
        //baseCount = (int)(baseCount * (AdvancedSettings.Universe.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / AdvancedSettings.BaryonicMatterNode.CountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / AdvancedSettings.BaryonicMatterNode.CountDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / AdvancedSettings.BaryonicMatterNode.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterNodeCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.DarkMatterNodeBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.DarkMatterNode.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.DarkMatterNode.CountMassFactor) * (context.Size * AdvancedSettings.DarkMatterNode.CountSizeFactor));
        //baseCount = (int)(baseCount * (AdvancedSettings.Universe.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / AdvancedSettings.DarkMatterNode.CountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / AdvancedSettings.DarkMatterNode.CountBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / AdvancedSettings.DarkMatterNode.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.BaryonicMatterSheetBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.BaryonicMatterSheet.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.BaryonicMatterSheet.CountMassFactor) * (context.Size * AdvancedSettings.BaryonicMatterSheet.CountSizeFactor));
        //baseCount = (int)(baseCount * (AdvancedSettings.Universe.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.BaryonicMatterPercent / AdvancedSettings.BaryonicMatterSheet.CountBaryonicMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / AdvancedSettings.BaryonicMatterSheet.CountDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / AdvancedSettings.BaryonicMatterSheet.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterSheetCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.DarkMatterSheetBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.DarkMatterSheet.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.DarkMatterSheet.CountMassFactor) * (context.Size * AdvancedSettings.DarkMatterSheet.CountSizeFactor));
        //baseCount = (int)(baseCount * (AdvancedSettings.Universe.BaselineExpansionRate / context.ExpansionRate));
        baseCount = (int)(baseCount * (context.CosmicMicrowaveBackground / AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (averageIntensity / 255.0));
        baseCount = (int)(baseCount * context.DarkMatterPercent / AdvancedSettings.DarkMatterSheet.CountDarkMatterPercentFactor);
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / AdvancedSettings.DarkMatterSheet.CountBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 - context.DarkEnergyPercent / AdvancedSettings.DarkMatterSheet.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetBaryonicMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.BaryonicMatterVoidBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }

        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.BaryonicMatterVoid.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.BaryonicMatterVoid.CountAgeFactor) * (context.Size * AdvancedSettings.BaryonicMatterVoid.CountSizeFactor));
        //baseCount = (int)(baseCount * (context.ExpansionRate / AdvancedSettings.Universe.BaselineExpansionRate));
        baseCount = (int)(baseCount * (AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.BaryonicMatterPercent / AdvancedSettings.BaryonicMatterVoid.CountBaryonicMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / AdvancedSettings.BaryonicMatterVoid.CountDarkEnergyPercentFactor));

        return baseCount;
    }
    private int GetDarkMatterVoidCount(CosmicWebContext context, float averageIntensity)
    {
        var baseCount = BasicSettings.DarkMatterVoidBaseCount;

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
            default:
                throw new ArgumentOutOfRangeException();
        }
        baseCount += (int)(context.Age * 1e-9 * AdvancedSettings.DarkMatterVoid.CountAgeFactor);
        baseCount = (int)(baseCount * (context.Mass * AdvancedSettings.DarkMatterVoid.CountMassFactor) * (context.Size * AdvancedSettings.DarkMatterVoid.CountSizeFactor));
        //baseCount = (int)(baseCount * (context.ExpansionRate / AdvancedSettings.Universe.BaselineExpansionRate));
        baseCount = (int)(baseCount * (AdvancedSettings.PhysicalConstants.BaselineCosmicMicrowaveBackground / context.CosmicMicrowaveBackground));
        baseCount = (int)(baseCount * (1 - averageIntensity / 255.0));
        baseCount = (int)(baseCount * (1 - context.DarkMatterPercent / AdvancedSettings.DarkMatterVoid.CountDarkMatterPercentFactor));
        baseCount = (int)(baseCount * (1 + context.DarkEnergyPercent / AdvancedSettings.DarkMatterVoid.CountDarkEnergyPercentFactor));

        return baseCount;
    }

    protected override void GenerateAge(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CosmicWebContext context, CosmicWeb self)
    {
        self.Position = new Vector3(0, 0, 0);
    }

    protected override void GenerateDiameter(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }
}