using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarGenerator : GeneratorBase<Quasar, QuasarContext>
{
    public QuasarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Quasar> GenerateSelf(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }
}