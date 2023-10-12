using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DysonSphereGenerator : GeneratorBase<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DysonSphere> GenerateSelf(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }
}