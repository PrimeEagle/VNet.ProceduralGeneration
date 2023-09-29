using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class BaryonicMatterSheetGenerator : BaseGenerator<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override BaryonicMatterSheet Generate(BaryonicMatterSheetContext context)
    {
        throw new NotImplementedException();
    }
}