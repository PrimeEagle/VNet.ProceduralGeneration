using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class MoonGenerator : GeneratorBase<Moon, MoonContext>
{
    public MoonGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Moon> GenerateSelf(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(MoonContext context, Moon self)
    {
        throw new NotImplementedException();
    }
}