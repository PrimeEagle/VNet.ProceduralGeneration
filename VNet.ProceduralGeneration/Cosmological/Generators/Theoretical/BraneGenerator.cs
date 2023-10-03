using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class BraneGenerator : GeneratorBase<Brane, BraneContext>
{
    public BraneGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Brane> GenerateSelf(BraneContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Brane self, BraneContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Brane self, BraneContext context)
    {
        throw new NotImplementedException();
    }
}