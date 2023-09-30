using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CometGenerator : BaseGenerator<Comet, CometContext>
{
    public override async Task<Comet> Generate(CometContext context)
    {
        var comet = new Comet
        {

        };

        return comet;
    }

    public CometGenerator() : base(ParallelismLevel.Level4)
    {
    }
}