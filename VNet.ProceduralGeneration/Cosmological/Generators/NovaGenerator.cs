using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : BaseGenerator<Nova, NovaContext>
{
    public override async Task<Nova> Generate(NovaContext context)
    {
        var nova = new Nova
        {

        };

        return nova;
    }

    public NovaGenerator() : base(ParallelismLevel.Level4)
    {
    }
}