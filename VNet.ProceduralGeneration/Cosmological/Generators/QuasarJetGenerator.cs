using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarJetGenerator : GeneratorBase<QuasarJet, QuasarJetContext>
{
    public QuasarJetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
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
}