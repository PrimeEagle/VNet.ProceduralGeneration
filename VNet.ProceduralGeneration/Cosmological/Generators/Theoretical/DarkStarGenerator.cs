using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DarkStarGenerator : BaseGenerator<DarkStar, DarkStarContext>
{
    public DarkStarGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override DarkStar Generate(DarkStarContext context)
    {
        throw new NotImplementedException();
    }
}