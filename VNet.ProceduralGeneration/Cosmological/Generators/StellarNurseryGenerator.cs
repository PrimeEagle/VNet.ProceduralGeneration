using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StellarNurseryGenerator : GeneratorBase<StellarNursery, StellarNurseryContext>
{
    public StellarNurseryGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<StellarNursery> GenerateSelf(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(StellarNurseryContext context, StellarNursery self)
    {
        throw new NotImplementedException();
    }
}