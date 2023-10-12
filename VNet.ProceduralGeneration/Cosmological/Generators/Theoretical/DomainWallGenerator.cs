using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DomainWallGenerator : GeneratorBase<DomainWall, DomainWallContext>
{
    public DomainWallGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DomainWall> GenerateSelf(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }
}