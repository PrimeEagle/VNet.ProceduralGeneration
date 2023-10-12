using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentGenerator : FilamentGeneratorBase<DarkMatterFilament, DarkMatterFilamentContext>
{
    protected override Task GenerateChildren(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateDiameter(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterFilament> GenerateSelf(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    public DarkMatterFilamentGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }
}