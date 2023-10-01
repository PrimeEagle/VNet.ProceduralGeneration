using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : BaseGenerator<Supercluster, SuperclusterContext>
{
    public SuperclusterGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Supercluster> GenerateSelf(SuperclusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Supercluster self, SuperclusterContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(Supercluster self, SuperclusterContext context)
    {
        throw new NotImplementedException();
    }
}