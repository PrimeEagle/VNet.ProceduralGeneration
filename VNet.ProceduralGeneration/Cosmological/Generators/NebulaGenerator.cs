using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NebulaGenerator : BaseGenerator<Nebula, NebulaContext>
{
    public override async Task<Nebula> Generate(NebulaContext context)
    {
        var nebula = new Nebula
        {

        };

        return nebula;
    }

    public NebulaGenerator() : base(ParallelismLevel.Level3)
    {
    }
}