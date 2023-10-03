using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BlackHoleGenerator : GeneratorBase<BlackHole, BlackHoleContext>
{
    public BlackHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<BlackHole> GenerateSelf(BlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BlackHole self, BlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BlackHole self, BlackHoleContext context)
    {
        throw new NotImplementedException();
    }
}