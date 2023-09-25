namespace VNet.ProceduralGeneration.Cosmological;

public class NebulaGenerator : IGeneratable<Nebula, NebulaContext>
{
    public Nebula Generate(NebulaContext context)
    {
        var nebula = new Nebula
        {
            // ... Generate properties specific to Nebula
        };
        return nebula;
    }
}