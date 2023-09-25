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
            // ... Generate properties specific to StellarFormationsAndObjects
        };

        // Generate Nebulae for this StellarFormationsAndObjects
        int nebulaCount = 0/* determine count based on some logic */;
        for (int i = 0; i < nebulaCount; i++)
        {
            formationsAndObjects.Nebulae.Add(_nebulaGenerator.Generate());
        }

        // Generate Supernovae for this StellarFormationsAndObjects
        int supernovaCount = 0/* determine count based on some logic */;
        for (int i = 0; i < supernovaCount; i++)
        {
            formationsAndObjects.Supernovae.Add(_supernovaGenerator.Generate());
        }

        // Generate a single Black Hole for this StellarFormationsAndObjects
        formationsAndObjects.BlackHole = _blackHoleGenerator.Generate();

        // Generate Neutron Stars for this StellarFormationsAndObjects
        int neutronStarCount = 0/* determine count based on some logic */;
        for (int i = 0; i < neutronStarCount; i++)
        {
            formationsAndObjects.NeutronStars.Add(_neutronStarGenerator.Generate());
        }

        return formationsAndObjects;
    }
}