using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterNodeGenerator : NodeGeneratorBase<BaryonicMatterNode, BaryonicMatterNodeContext>
{
    public BaryonicMatterNodeGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
        Enabled = ObjectToggles.BaryonicMatterNodesEnabled;
    }

    protected override async Task GenerateChildren(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
    }

    protected override void GenerateInteriorObjects(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override async Task<BaryonicMatterNode> GenerateSelf(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        //if (context.SpatialGrid != null)
        //{
        //    var basePosition = context.SpatialGrid.FetchNextAvailableCell();
        //    if (!basePosition.HasValue) return self;

        //    self.Position = TransformBasePosition(basePosition.Value);
        //    self.Position += Util.GetRandomOffset(AdvancedSettings.Objects.BaryonicMatterNode.TopologyMaxPositionalOffset);
        //    self.Luminosity = context.Topology.VolumeMap[basePosition.Value.Item1, basePosition.Value.Item2, basePosition.Value.Item3];
        //}
        //else
        //{
        //    var xStart = -1 * BasicSettings.MapDimensions.X / 2;
        //    var xEnd = BasicSettings.MapDimensions.X / 2;

        //    var yStart = -1 * BasicSettings.MapDimensions.Y / 2;
        //    var yEnd = BasicSettings.MapDimensions.Y / 2;

        //    var zStart = -1 * BasicSettings.MapDimensions.Z / 2;
        //    var zEnd = BasicSettings.MapDimensions.Z / 2;

        //    var x = xStart + (xEnd - xStart) * AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingle();
        //    var y = yStart + (yEnd - yStart) * AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingle();
        //    var z = zStart + (zEnd - zStart) * AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingle();

        //    self.Position = new Vector3(x, y, z);
        //    self.Luminosity = -30 + 60 * AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingle();
        //}

        return self;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    //    return shiftedVector;
    //}
    internal override void AssignChildren(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterNodeContext context, BaryonicMatterNode self)
    {
        throw new NotImplementedException();
    }

    //private Vector3 TransformBasePosition((int, int, int) basePosition)
    //{
    //    var posX = basePosition.Item1;
    //    var posY = basePosition.Item2;
    //    var posZ = basePosition.Item3;

    //    var mapX = BasicSettings.MapDimensions.X;
    //    var mapY = BasicSettings.MapDimensions.Y;
    //    var mapZ = BasicSettings.MapDimensions.Z;

    //    var xScale = posX / mapX;
    //    var yScale = posY / mapY;
    //    var zScale = posZ / mapZ;

    //    var baseVector = new Vector3(posX / xScale, posY / yScale, posZ / zScale);
    //    var shiftedVector = baseVector - new Vector3(mapX / 2, mapY / 2, mapZ / 2);
}