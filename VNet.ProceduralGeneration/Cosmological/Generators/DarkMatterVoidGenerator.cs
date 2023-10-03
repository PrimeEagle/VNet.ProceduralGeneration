using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidGenerator : GeneratorBase<DarkMatterVoid, DarkMatterVoidContext>
{
    public DarkMatterVoidGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterVoid> GenerateSelf(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(DarkMatterVoidContext context, DarkMatterVoid self)
    {
        throw new NotImplementedException();
    }
}