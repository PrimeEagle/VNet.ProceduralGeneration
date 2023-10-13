using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : GeneratorBase<BlackHole, BlackHoleContext>
{
    public BlackHoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<BlackHole> GenerateSelf(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BlackHoleContext context, BlackHole self)
    {
        throw new NotImplementedException();
    }
}