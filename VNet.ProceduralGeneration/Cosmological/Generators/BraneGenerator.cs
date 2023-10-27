using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BraneGenerator : GeneratorBase<Brane, BraneContext>
{
    public BraneGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Brane> GenerateSelf(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }
}