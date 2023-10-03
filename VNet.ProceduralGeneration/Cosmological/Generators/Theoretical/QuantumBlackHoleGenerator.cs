using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuantumBlackHoleGenerator : GeneratorBase<QuantumBlackHole, QuantumBlackHoleContext>
{
    public QuantumBlackHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<QuantumBlackHole> GenerateSelf(QuantumBlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuantumBlackHole self, QuantumBlackHoleContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuantumBlackHole self, QuantumBlackHoleContext context)
    {
        throw new NotImplementedException();
    }
}