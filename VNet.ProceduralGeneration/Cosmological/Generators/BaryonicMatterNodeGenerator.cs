using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeGenerator : BaseGenerator<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator() : base(ParallelismLevel.Level1)
    {
        enabled = ObjectToggles.BaryonicMatterNodesEnabled;
    }

    protected override Task<BaryonicMatterNode> GenerateSelf(BaryonicMatterNodeContext context)
    {
        //private List<NodeSeed> GenerateNodeSeeds(CosmicWebTopology topology, int numberToGenerate, NodeConfiguration nodeConfig)
        //{
        //var nodeSeeds = new List<NodeSeed>();

        //var densityThreshold = topology.AverageIntensity * nodeConfig.NodeDensityThresholdFactor;
        //var gradientMagnitudeThreshold = topology.MaxGradientMagnitude * nodeConfig.NodeGradientMagnitudeThresholdFactor;

        //var width = topology.VolumeMap.GetLength(0);
        //var height = topology.VolumeMap.GetLength(1);
        //var depth = topology.VolumeMap.GetLength(2);

        //Parallel.For(0, width, x =>
        //{
        //    for (var y = 0; y < height; y++)
        //    {
        //        for (var z = 0; z < depth; z++)
        //        {
        //            var intensity = topology.VolumeMap[x, y, z];
        //            if (intensity <= densityThreshold) continue;

        //            var gradient = topology.GradientMap[x, y, z];
        //            if (gradient.Length() <= gradientMagnitudeThreshold) continue;

        //            var position = new Vector3(x, y, z) + Util.GetRandomOffset(nodeConfig.NodeMaxPositionalOffset);
        //            nodeSeeds.Add(new NodeSeed(position, intensity));
        //        }
        //    }
        //});

        //return new List<NodeSeed>(seedsList);
        //}
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}