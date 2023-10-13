using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DomainWallGenerator : GeneratorBase<DomainWall, DomainWallContext>
{
    public DomainWallGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }
}