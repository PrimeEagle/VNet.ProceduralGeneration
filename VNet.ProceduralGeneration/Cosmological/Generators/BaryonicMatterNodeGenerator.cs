using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeGenerator : GeneratorBase<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
        enabled = ObjectToggles.BaryonicMatterNodesEnabled;
    }

    protected async override Task<BaryonicMatterNode> GenerateSelf(BaryonicMatterNodeContext context)
    {
        var node = new BaryonicMatterNode();

        if (context.SpatialGrid != null)
        {
            var basePosition = context.SpatialGrid.FetchNextAvailableCell();
            if (!basePosition.HasValue) return node;

            node.Position = TransformBasePosition(basePosition.Value);
            node.Position += Util.GetRandomOffset(AdvancedSettings.BaryonicMatterNode.TopologyMaxPositionalOffset);
            node.AbsoluteMagnitude = context.Topology.VolumeMap[basePosition.Value.Item1, basePosition.Value.Item2, basePosition.Value.Item3];
        }
        else
        {
            var xStart = -1 * BasicSettings.DimensionX / 2;
            var xEnd = BasicSettings.DimensionX / 2;
            
            var yStart = -1 * BasicSettings.DimensionY / 2;
            var yEnd = BasicSettings.DimensionY / 2;
            
            var zStart = -1 * BasicSettings.DimensionZ / 2;
            var zEnd = BasicSettings.DimensionZ / 2;

            var x = xStart + (xEnd - xStart) * AdvancedSettings.Universe.RandomGenerator.NextSingle();
            var y = yStart + (yEnd - yStart) * AdvancedSettings.Universe.RandomGenerator.NextSingle();
            var z = zStart + (zEnd - zStart) * AdvancedSettings.Universe.RandomGenerator.NextSingle();

            node.Position = new Vector3(x, y, z);
            node.AbsoluteMagnitude = -30 + (60) * AdvancedSettings.Universe.RandomGenerator.NextSingle();
        }

        

        return node;
    }

    protected async override Task GenerateChildren(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        
    }

    protected override Task PostProcess(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        return null;
    }

    private Vector3 TransformBasePosition((int, int, int) basePosition)
    {
        var posX = basePosition.Item1;
        var posY = basePosition.Item2;
        var posZ = basePosition.Item3;
        
        var mapX = BasicSettings.DimensionX;
        var mapY = BasicSettings.DimensionY;
        var mapZ = BasicSettings.DimensionZ;

        var xScale = posX / mapX;
        var yScale = posY / mapY;
        var zScale = posZ / mapZ;

        var baseVector = new Vector3(posX / xScale, posY / yScale, posZ / zScale);
        var shiftedVector = baseVector - new Vector3(mapX / 2, mapY / 2, mapZ / 2);

        return shiftedVector;
    }
}