using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class PreonStarGenerator : BaseGenerator<PreonStar, PreonStarContext>
{
    public PreonStarGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override PreonStar Generate(PreonStarContext context)
    {
        throw new NotImplementedException();
    }
}