namespace VNet.ProceduralGeneration.Cosmological;

public class PlanetGenerator : BaseGenerator<Planet, PlanetContext>
{
    private readonly MoonGenerator _sateliteGenerator;


    public override Planet Generate(PlanetContext context)
    {
        var planet = new Planet();


        int satelliteCount = 0;
        for (int i = 0; i < satelliteCount; i++)
        {
            planet.Moons.Add(_sateliteGenerator.Generate(new MoonContext()));
        }

        return planet;
    }

    public PlanetGenerator(GeneratorConfig config) : base(config)
    {
        _sateliteGenerator = new MoonGenerator(config);
    }
}