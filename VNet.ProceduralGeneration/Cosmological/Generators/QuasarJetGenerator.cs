using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarJetGenerator : GeneratorBase<QuasarJet, QuasarJetContext>
{
    public QuasarJetGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<QuasarJet> GenerateSelf(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }
}