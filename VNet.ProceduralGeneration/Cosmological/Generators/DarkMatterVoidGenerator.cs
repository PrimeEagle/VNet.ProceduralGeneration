using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidGenerator : ContainerGeneratorBase<DarkMatterVoid, DarkMatterVoidContext>
{
    public DarkMatterVoidGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterVoid> GenerateSelf(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }
}