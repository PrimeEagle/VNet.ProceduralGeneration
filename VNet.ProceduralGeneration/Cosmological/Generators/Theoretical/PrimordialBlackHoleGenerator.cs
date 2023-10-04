using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class PrimordialBlackHoleGenerator : GeneratorBase<PrimordialBlackHole, PrimordialBlackHoleContext>
{
    public PrimordialBlackHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<PrimordialBlackHole> GenerateSelf(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(PrimordialBlackHoleContext context, PrimordialBlackHole self)
    {
        throw new NotImplementedException();
    }
}