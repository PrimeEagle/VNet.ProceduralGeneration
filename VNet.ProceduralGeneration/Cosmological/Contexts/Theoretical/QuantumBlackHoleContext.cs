namespace VNet.ProceduralGeneration.Cosmological;

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