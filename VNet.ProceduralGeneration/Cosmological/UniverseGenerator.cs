namespace VNet.ProceduralGeneration.Cosmological;

public class UniverseGenerator : IGeneratable<Universe, UniverseContext>
{
    private readonly CosmicWebGenerator _cosmicWebGenerator = new CosmicWebGenerator();

    public Universe Generate(UniverseContext context)
    {
        var universe = new Universe
        {
            Age = context.Age
        };

        const float lightYearsToAU = 6.323e4f; // Convert light-years to AU

        if (universe.UniverseBoundedness == Boundedness.Finite)
        {
            universe.Size = context.Age * 3.5f; // A hypothetical factor to determine size based on age for a finite universe, this will still be in light-years for simplicity
        }
        else
        {
            universe.Size = context.Age; // For infinite universe, equate observable universe's size to age (in light-years)
        }

        // Convert the size from light-years to AUs
        universe.Size *= lightYearsToAU;

        universe.UniverseBoundedness = RandomChance(0.85) ? Boundedness.Infinite : Boundedness.Finite;
        double curvatureChance = RandomValue(0, 1);
        universe.UniverseCurvature = curvatureChance < 0.90 ? Curvature.Flat :
            curvatureChance < 0.95 ? Curvature.Spherical :
            Curvature.Hyperbolic;
        universe.UniverseConnectivity = RandomChance(0.95) ? Connectivity.SimplyConnected : Connectivity.MultiplyConnected;
        universe.CosmicMicrowaveBackground = 2.725 - (context.Age * 0.0001);
        universe.CosmicInflation = context.Age < 1e8; // 0.1 billion years
        universe.ExpansionRate = Math.Min(67.5 + (context.Age * 0.002), 73.5);
        universe.DarkEnergy = 0.68 * universe.Mass;


        var cosmicWebContext = new CosmicWebContext
        {
            Age = context.Age,
            ExpansionRate = context.ExpansionRate,
            DarkEnergy = context.DarkEnergy,
            Curvature = context.UniverseCurvature,
            Size = universe.Size // Assuming you've calculated size in this generator
        };

        universe.CosmicWeb = _cosmicWebGenerator.Generate(cosmicWebContext);




        return universe;
    }

    private double RandomValue(double min, double max)
    {
        Random rnd = new Random();
        return rnd.NextDouble() * (max - min) + min;
    }

    private bool RandomChance(double probability)
    {
        return RandomValue(0, 1) < probability;
    }

    public Universe Generate()
    {
        throw new NotImplementedException();
    }
}