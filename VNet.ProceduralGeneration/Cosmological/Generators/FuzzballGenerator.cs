using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class FuzzballGenerator : GeneratorBase<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Fuzzball> GenerateSelf(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(FuzzballContext context, Fuzzball self)
    {
        throw new NotImplementedException();
    }
}