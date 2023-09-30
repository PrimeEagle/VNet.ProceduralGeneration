using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;

public class QuantumBlackHoleContext : BaseContext
{
    public QuantumBlackHoleContext()
    {

    }

    public QuantumBlackHoleContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties((AstronomicalObject)cosmicWeb);
    }
}