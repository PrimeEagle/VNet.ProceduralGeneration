using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PreonStarGenerator : GeneratorBase<PreonStar, PreonStarContext>
{
    public PreonStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<PreonStar> GenerateSelf(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PreonStarContext context, PreonStar self)
    {
        throw new NotImplementedException();
    }
}