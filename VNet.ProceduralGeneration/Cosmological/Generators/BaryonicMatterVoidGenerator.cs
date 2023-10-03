using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : GeneratorBase<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }
}