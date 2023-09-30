using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class NebulaGenerator : BaseGenerator<Nebula, NebulaContext>
{
    public async override Task<Nebula> Generate(NebulaContext context)
    {
        var nebula = new Nebula
        {

        };

        return nebula;
    }

    public NebulaGenerator()
    {
    }
}