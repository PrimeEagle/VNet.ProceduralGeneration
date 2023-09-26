namespace VNet.ProceduralGeneration.Cosmological;

public class StellarFormationsAndObjectsGenerator : IGeneratable<StellarFormationsAndObjects, StellarFormationsAndObjectsContext>
{
    private readonly NebulaGenerator _nebulaGenerator = new NebulaGenerator();
    private readonly SupernovaGenerator _supernovaGenerator = new SupernovaGenerator();
    private readonly BlackHoleGenerator _blackHoleGenerator = new BlackHoleGenerator();
    private readonly NeutronStarGenerator _neutronStarGenerator = new NeutronStarGenerator();

    public StellarFormationsAndObjects Generate(StellarFormationsAndObjectsContext context)
    {
        var formationsAndObjects = new StellarFormationsAndObjects
        {
        };

        int nebulaCount = 0;
        for (int i = 0; i < nebulaCount; i++)
        {
            formationsAndObjects.Nebulae.Add(_nebulaGenerator.Generate(new NebulaContext()));
        }

        int supernovaCount = 0;
        for (int i = 0; i < supernovaCount; i++)
        {
            formationsAndObjects.Supernovae.Add(_supernovaGenerator.Generate(new SupernovaContext()));
        }

        formationsAndObjects.BlackHole = _blackHoleGenerator.Generate(new BlackHoleContext());

        int neutronStarCount = 0;
        for (int i = 0; i < neutronStarCount; i++)
        {
            formationsAndObjects.NeutronStars.Add(_neutronStarGenerator.Generate(new NeutronStarContext()));
        }

        return formationsAndObjects;
    }
}