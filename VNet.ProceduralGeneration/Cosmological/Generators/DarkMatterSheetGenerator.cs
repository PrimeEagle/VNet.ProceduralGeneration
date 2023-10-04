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

    protected override float GenerateAge(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(DarkMatterSheetContext context, DarkMatterSheet self)
    {
        throw new NotImplementedException();
    }
}