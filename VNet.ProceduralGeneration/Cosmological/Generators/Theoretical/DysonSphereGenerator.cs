using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DysonSphereGenerator : BaseGenerator<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<DysonSphere> Generate(DysonSphereContext context)
    {
        var result = new DysonSphere();
        return result;
    }
}