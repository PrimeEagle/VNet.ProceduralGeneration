using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DysonSphereGenerator : BaseGenerator<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<DysonSphere> GenerateSelf(DysonSphereContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DysonSphere self, DysonSphereContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DysonSphere self, DysonSphereContext context)
    {
        throw new NotImplementedException();
    }
}