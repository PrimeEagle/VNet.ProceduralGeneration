using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NeutronStarGenerator : GeneratorBase<NeutronStar, NeutronStarContext>
{
    public NeutronStarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<NeutronStar> GenerateSelf(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }
}