using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ExocometaryCloudGenerator : GroupGeneratorBase<ExocometaryCloud, ExocometaryCloudContext>
{
    public ExocometaryCloudGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<ExocometaryCloud> GenerateSelf(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(ExocometaryCloudContext context, ExocometaryCloud self)
    {
        throw new NotImplementedException();
    }
}