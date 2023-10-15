using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarGenerator : GeneratorBase<Star, StarContext>
{
    public StarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Star> GenerateSelf(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StarContext context, Star self)
    {
        throw new NotImplementedException();
    }
}