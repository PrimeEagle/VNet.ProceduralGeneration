using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaGenerator : BaseGenerator<Supernova, SupernovaContext>
{
    public override async Task<Supernova> Generate(SupernovaContext context)
    {
        var supernova = new Supernova
        {

        };

        return supernova;
    }

    public SupernovaGenerator() : base(ParallelismLevel.Level4)
    {
    }
}