using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DomainWallGenerator : BaseGenerator<DomainWall, DomainWallContext>
{
    public DomainWallGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<DomainWall> GenerateSelf(DomainWallContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DomainWall self, DomainWallContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DomainWall self, DomainWallContext context)
    {
        throw new NotImplementedException();
    }
}