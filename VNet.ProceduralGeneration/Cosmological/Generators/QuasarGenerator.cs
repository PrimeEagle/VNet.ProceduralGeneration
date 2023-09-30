using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarGenerator : BaseGenerator<Quasar, QuasarContext>
{
    public override async Task<Quasar> Generate(QuasarContext context)
    {
        throw new NotImplementedException();
    }

    public QuasarGenerator() : base(ParallelismLevel.Level3)
    {
    }
}