using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterFilamentGenerator : FilamentGeneratorBase<DarkMatterFilament, DarkMatterFilamentContext>
{
    public DarkMatterFilamentGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterFilamentContext context, DarkMatterFilament self)
    {
        throw new NotImplementedException();
    }
}