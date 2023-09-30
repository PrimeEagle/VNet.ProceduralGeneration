using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DomainWallGenerator : BaseGenerator<DomainWall, DomainWallContext>
{
    public DomainWallGenerator()
    {
    }

    public async override Task<DomainWall> Generate(DomainWallContext context)
    {
        var result = new DomainWall();
        return result;
    }
}