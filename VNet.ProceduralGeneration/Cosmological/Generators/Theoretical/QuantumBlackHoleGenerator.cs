using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuantumBlackHoleGenerator : BaseGenerator<QuantumBlackHole, QuantumBlackHoleContext>
{
    public QuantumBlackHoleGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<QuantumBlackHole> Generate(QuantumBlackHoleContext context)
    {
        var result = new QuantumBlackHole();
        return result;
    }
}