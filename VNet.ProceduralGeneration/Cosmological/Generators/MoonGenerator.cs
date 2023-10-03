using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : GeneratorBase<Moon, MoonContext>
{
    public MoonGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Moon> GenerateSelf(MoonContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Moon self, MoonContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Moon self, MoonContext context)
    {
        throw new NotImplementedException();
    }
}