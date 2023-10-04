using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterFilamentGenerator : GeneratorBase<BaryonicMatterFilament, BaryonicMatterFilamentContext>
{
    public BaryonicMatterFilamentGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }


    protected override Task<BaryonicMatterFilament> GenerateSelf(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(BaryonicMatterFilamentContext context, BaryonicMatterFilament self)
    {
        throw new NotImplementedException();
    }
}