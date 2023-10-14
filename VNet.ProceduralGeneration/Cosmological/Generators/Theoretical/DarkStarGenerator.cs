using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DarkStarGenerator : GeneratorBase<DarkStar, DarkStarContext>
{
    public DarkStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkStar> GenerateSelf(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkStarContext context, DarkStar self)
    {
        throw new NotImplementedException();
    }
}