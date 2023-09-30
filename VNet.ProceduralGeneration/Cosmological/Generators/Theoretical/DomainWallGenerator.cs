using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DomainWallGenerator : BaseGenerator<DomainWall, DomainWallContext>
{
    public DomainWallGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<DomainWall> Generate(DomainWallContext context)
    {
        var result = new DomainWall();
        return result;
    }
}