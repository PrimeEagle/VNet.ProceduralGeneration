using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DomainWallGenerator : BaseGenerator<DomainWall, DomainWallContext>
{
    public DomainWallGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override DomainWall Generate(DomainWallContext context)
    {
        throw new NotImplementedException();
    }
}