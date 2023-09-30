using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class DysonSphereGenerator : BaseGenerator<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator()
    {
    }

    public async override Task<DysonSphere> Generate(DysonSphereContext context)
    {
        var result = new DysonSphere();
        return result;
    }
}