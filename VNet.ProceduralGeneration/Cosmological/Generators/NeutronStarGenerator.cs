using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NeutronStarGenerator : GeneratorBase<NeutronStar, NeutronStarContext>
{
    public NeutronStarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
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

    protected override float GenerateAge(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(NeutronStarContext context, NeutronStar self)
    {
        throw new NotImplementedException();
    }
}