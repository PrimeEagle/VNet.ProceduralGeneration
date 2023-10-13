using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeGenerator : NodeGeneratorBase<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
        Enabled = ObjectToggles.BaryonicMatterNodesEnabled;
    }

    protected override async Task<BaryonicMatterNode> GenerateSelf(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        if (context.SpatialGrid != null)
        {
            var basePosition = context.SpatialGrid.FetchNextAvailableCell();
            if (!basePosition.HasValue) return self;

            self.Position = TransformBasePosition(basePosition.Value);
            self.Position += Util.GetRandomOffset(AdvancedSettings.BaryonicMatterNode.TopologyMaxPositionalOffset);
            self.Luminosity = context.Topology.VolumeMap[basePosition.Value.Item1, basePosition.Value.Item2, basePosition.Value.Item3];
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

            self.Position = new Vector3(x, y, z);
            self.Luminosity = -30 + 60 * AdvancedSettings.Universe.RandomGenerator.NextSingle();
        }

        return self;
    }

    protected override async Task GenerateChildren(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
    }

    protected override void SetMatterType(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
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

    protected override void GenerateWarpedSurface(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }
}