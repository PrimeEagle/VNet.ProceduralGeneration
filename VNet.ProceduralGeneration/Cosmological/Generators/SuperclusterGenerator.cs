using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : BaseGenerator<Supercluster, SuperclusterContext>
{
    public override async Task<Supercluster> Generate(SuperclusterContext context)
    {
        var supercluster = new Supercluster
        {
        };

        return supercluster;
    }

    public SuperclusterGenerator() : base(ParallelismLevel.Level2)
    {
    }
}