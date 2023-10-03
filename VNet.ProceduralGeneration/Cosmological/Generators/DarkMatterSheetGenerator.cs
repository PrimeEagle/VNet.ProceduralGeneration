using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterSheetGenerator : GeneratorBase<DarkMatterSheet, DarkMatterSheetContext>
{
    public DarkMatterSheetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
    }

    protected override Task<DarkMatterSheet> GenerateSelf(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }
}