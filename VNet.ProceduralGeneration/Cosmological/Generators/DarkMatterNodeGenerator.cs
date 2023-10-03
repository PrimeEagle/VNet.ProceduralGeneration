using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : GeneratorBase<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
        enabled = ObjectToggles.DarkMatterNodesEnabled;
    }

    protected override Task<DarkMatterNode> GenerateSelf(DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterNode self, DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterNode self, DarkMatterNodeContext context)
    {
        throw new NotImplementedException();
    }
}