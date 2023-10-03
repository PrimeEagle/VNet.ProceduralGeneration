using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidGenerator : GeneratorBase<DarkMatterVoid, DarkMatterVoidContext>
{
    public DarkMatterVoidGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterVoid> GenerateSelf(DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterVoid self, DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterVoid self, DarkMatterVoidContext context)
    {
        throw new NotImplementedException();
    }
}