using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

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

    public override void GenerateRandomGenerationAlgorithm(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DomainWallContext context, DomainWall self)
    {
        throw new NotImplementedException();
    }
}