using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class GalaxyGenerator : ContainerGeneratorBase<Galaxy, GalaxyContext>
{
    public GalaxyGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Galaxy> GenerateSelf(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(GalaxyContext context, Galaxy self)
    {
        throw new NotImplementedException();
    }
}