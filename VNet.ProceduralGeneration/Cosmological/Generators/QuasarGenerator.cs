using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarGenerator : GeneratorBase<Quasar, QuasarContext>
{
    public QuasarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Quasar> GenerateSelf(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }
}