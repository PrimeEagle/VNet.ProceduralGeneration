using System.Numerics;
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

    protected async override Task<BaryonicMatterNode> GenerateSelf(BaryonicMatterNodeContext context)
    {
        var node = new BaryonicMatterNode();

        var basePosition = context.SpatialGrid.FetchNextAvailableCell();
        if (!basePosition.HasValue) return node;

        node.Position = new Vector3(basePosition.Value.Item1, basePosition.Value.Item2, basePosition.Value.Item3);
        node.Position += Util.GetRandomOffset(AdvancedSettings.BaryonicMatterNode.TopologyMaxPositionalOffset);

        return node;
    }

    protected async override Task GenerateChildren(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        
    }

    protected override Task PostProcess(BaryonicMatterNode self, BaryonicMatterNodeContext context)
    {
        return null;
    }
}