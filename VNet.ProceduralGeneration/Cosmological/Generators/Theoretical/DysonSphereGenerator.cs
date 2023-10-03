using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DysonSphereGenerator : GeneratorBase<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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

    protected override Task PostProcess(DysonSphere self, DysonSphereContext context)
    {
        throw new NotImplementedException();
    }
}