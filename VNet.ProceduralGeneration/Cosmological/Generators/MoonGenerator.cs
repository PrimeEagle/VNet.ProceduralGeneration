using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : GeneratorBase<Moon, MoonContext>
{
    public MoonGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Moon> GenerateSelf(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }
}