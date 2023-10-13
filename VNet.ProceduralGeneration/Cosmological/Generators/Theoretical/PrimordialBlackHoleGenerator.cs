using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PrimordialBlackHoleGenerator : GeneratorBase<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<PrimordialBlackHole> GenerateSelf(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }
}