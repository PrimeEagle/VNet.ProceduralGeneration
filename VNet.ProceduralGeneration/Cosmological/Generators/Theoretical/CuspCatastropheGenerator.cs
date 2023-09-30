using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class CuspCatastropheGenerator : BaseGenerator<CuspCatastrophe, CuspCatastropheContext>
{
    public CuspCatastropheGenerator()
    {
    }

    public async override Task<CuspCatastrophe> Generate(CuspCatastropheContext context)
    {
        var result = new CuspCatastrophe();
        return result;
    }
}