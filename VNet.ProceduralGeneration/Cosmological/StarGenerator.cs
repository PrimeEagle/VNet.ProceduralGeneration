namespace VNet.ProceduralGeneration.Cosmological;

public class StarGenerator : IGeneratable<Star, StarContext>
{
    public Star Generate(StarContext context)
    {
        var star = new Star
        {
            // ... Generate properties specific to Star
        };
        return star;
    }
}