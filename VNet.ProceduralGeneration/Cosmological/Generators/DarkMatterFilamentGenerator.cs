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

    protected override Task<DarkMatterFilament> GenerateSelf(DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterFilament self, DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterFilament self, DarkMatterFilamentContext context)
    {
        throw new NotImplementedException();
    }
}