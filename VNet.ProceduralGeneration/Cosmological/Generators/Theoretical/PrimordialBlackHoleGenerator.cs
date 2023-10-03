using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PrimordialBlackHoleGenerator : GeneratorBase<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<PrimordialBlackHole> GenerateSelf(PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PrimordialBlackHole self, PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PrimordialBlackHole self, PrimordialBlackHoleContext context)
    {
        throw new NotImplementedException();
    }
}