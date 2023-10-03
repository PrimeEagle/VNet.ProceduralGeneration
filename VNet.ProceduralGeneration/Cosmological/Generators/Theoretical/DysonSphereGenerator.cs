using System.Numerics;
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

    protected override Task<DysonSphere> GenerateSelf(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }
}