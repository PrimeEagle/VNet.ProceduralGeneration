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

    protected override float CalculateAge(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(QuasarContext context, Quasar self)
    {
        throw new NotImplementedException();
    }
}