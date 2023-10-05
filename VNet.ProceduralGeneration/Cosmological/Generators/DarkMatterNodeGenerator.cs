using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : ContainerGeneratorBase<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterNode> GenerateSelf(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }
}