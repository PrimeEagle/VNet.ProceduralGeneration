using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DarkMatterSheetGenerator : BaseGenerator<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override DarkMatterSheet Generate(DarkMatterSheetContext context)
    {
        throw new NotImplementedException();
    }
}