using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class BraneGenerator : BaseGenerator<Brane, BraneContext>
{
    public BraneGenerator() : base(ParallelismLevel.Level4)
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