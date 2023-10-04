using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterSheetGenerator : GeneratorBase<BaryonicMatterSheet, BaryonicMatterSheetContext>
{
    public BaryonicMatterSheetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<BaryonicMatterSheet> GenerateSelf(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(BaryonicMatterSheetContext context, BaryonicMatterSheet self)
    {
        throw new NotImplementedException();
    }
}