using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class StarSystemGenerator : ContainerGeneratorBase<StarSystem, StarSystemContext>
{
    public StarSystemGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task<StarSystem> GenerateSelf(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(StarSystemContext context, StarSystem self)
    {
        throw new NotImplementedException();
    }
}