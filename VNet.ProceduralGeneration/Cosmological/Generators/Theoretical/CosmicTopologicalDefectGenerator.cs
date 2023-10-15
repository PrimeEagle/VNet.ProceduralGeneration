using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTopologicalDefectGenerator : GeneratorBase<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<CosmicTopologicalDefect> GenerateSelf(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }
}