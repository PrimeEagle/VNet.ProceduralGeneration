using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicStringGenerator : GeneratorBase<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<CosmicString> GenerateSelf(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }
}