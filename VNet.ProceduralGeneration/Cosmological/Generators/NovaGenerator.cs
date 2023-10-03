using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : GeneratorBase<Nova, NovaContext>
{
    public NovaGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Nova> GenerateSelf(NovaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Nova self, NovaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Nova self, NovaContext context)
    {
        throw new NotImplementedException();
    }
}