using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaRemnantGenerator : GeneratorBase<SupernovaRemnant, SupernovaRemnantContext>
{
    public SupernovaRemnantGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<SupernovaRemnant> GenerateSelf(SupernovaRemnantContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaRemnant self, SupernovaRemnantContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SupernovaRemnant self, SupernovaRemnantContext context)
    {
        throw new NotImplementedException();
    }
}