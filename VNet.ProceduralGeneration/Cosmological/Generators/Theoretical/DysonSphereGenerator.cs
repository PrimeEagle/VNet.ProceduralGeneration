using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class DysonSphereGenerator : GeneratorBase<DysonSphere, DysonSphereContext>
{
    public DysonSphereGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DysonSphereContext context, DysonSphere self)
    {
        throw new NotImplementedException();
    }
}