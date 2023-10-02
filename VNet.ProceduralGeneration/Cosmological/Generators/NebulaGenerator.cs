using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NebulaGenerator : BaseGenerator<Nebula, NebulaContext>
{
    public NebulaGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Nebula> GenerateSelf(NebulaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Nebula self, NebulaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Nebula self, NebulaContext context)
    {
        throw new NotImplementedException();
    }
}