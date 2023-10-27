using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class WhiteHoleGenerator : GeneratorBase<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<WhiteHole> GenerateSelf(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }
}