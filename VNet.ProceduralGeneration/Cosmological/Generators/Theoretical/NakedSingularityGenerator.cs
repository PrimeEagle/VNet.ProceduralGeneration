using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class NakedSingularityGenerator : GeneratorBase<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<NakedSingularity> GenerateSelf(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }
}