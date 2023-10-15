using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class QuasarJetGenerator : GeneratorBase<QuasarJet, QuasarJetContext>
{
    public QuasarJetGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(QuasarJetContext context, QuasarJet self)
    {
        throw new NotImplementedException();
    }
}