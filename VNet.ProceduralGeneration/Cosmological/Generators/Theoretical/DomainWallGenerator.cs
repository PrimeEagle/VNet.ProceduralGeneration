using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DomainWallGenerator : GeneratorBase<DomainWall, DomainWallContext>
{
    public DomainWallGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<DomainWall> GenerateSelf(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }
}