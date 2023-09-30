using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class QuantumBlackHoleGenerator : BaseGenerator<QuantumBlackHole, QuantumBlackHoleContext>
{
    public QuantumBlackHoleGenerator()
    {
    }

    public async override Task<QuantumBlackHole> Generate(QuantumBlackHoleContext context)
    {
        var result = new QuantumBlackHole();
        return result;
    }
}