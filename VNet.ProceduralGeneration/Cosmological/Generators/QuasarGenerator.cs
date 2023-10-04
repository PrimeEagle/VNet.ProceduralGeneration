using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarGenerator : GeneratorBase<Quasar, QuasarContext>
{
    public QuasarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
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

    protected override Task PostProcess(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }
}