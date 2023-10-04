using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentGenerator : GeneratorBase<DarkMatterFilament, DarkMatterFilamentContext>
{
    public DarkMatterFilamentGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterFilament> GenerateSelf(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }
}