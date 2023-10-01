using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MonopoleGenerator : BaseGenerator<Monopole, MonopoleContext>
{
    public MonopoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Monopole> GenerateSelf(MonopoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Monopole self, MonopoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(Monopole self, MonopoleContext context)
    {
        throw new NotImplementedException();
    }
}