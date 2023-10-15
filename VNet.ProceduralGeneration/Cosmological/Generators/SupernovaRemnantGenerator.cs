using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : GeneratorBase<SupernovaRemnant, SupernovaRemnantContext>
{
    public SupernovaRemnantGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<SupernovaRemnant> GenerateSelf(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SupernovaRemnantContext context, SupernovaRemnant self)
    {
        throw new NotImplementedException();
    }
}