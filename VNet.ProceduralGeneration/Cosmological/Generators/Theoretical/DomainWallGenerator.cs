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

    protected override Task<DomainWall> GenerateSelf(DomainWallContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DomainWall self, DomainWallContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DomainWall self, DomainWallContext context)
    {
        throw new NotImplementedException();
    }
}