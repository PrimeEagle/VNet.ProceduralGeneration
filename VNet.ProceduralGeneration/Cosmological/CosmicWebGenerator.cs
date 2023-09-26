namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    private readonly BaryonicFilamentGenerator _baryonicFilamentGenerator;
    private readonly DarkMatterFilamentGenerator _darkMatterFilamentGenerator;
    private readonly BaryonicNodeGenerator _baryonicNodeGenerator;
    private readonly DarkMatterNodeGenerator _darkMatterNodeGenerator;
    private readonly BaryonicVoidGenerator _baryonicVoidGenerator;
    private readonly DarkMatterVoidGenerator _darkMatterVoidGenerator;


    public override CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb();

        int baryonicFilamentCount = GetBaryonicFilamentCount(context);
        for (int i = 0; i < baryonicFilamentCount; i++)
        {
            cosmicWeb.BaryonicFilaments.Add(_baryonicFilamentGenerator.Generate(new BaryonicFilamentContext(cosmicWeb)));
        }

        int darkMatterFilamentCount = GetDarkMatterFilamentCount(context);
        for (int i = 0; i < darkMatterFilamentCount; i++)
        {
            cosmicWeb.DarkMatterFilaments.Add(_darkMatterFilamentGenerator.Generate(new DarkMatterFilamentContext(cosmicWeb)));
        }

        int baryonicNodeCount = GetBaryonicNodeCount(context);
        for (int i = 0; i < baryonicNodeCount; i++)
        {
            cosmicWeb.BaryonicNodes.Add(_baryonicNodeGenerator.Generate(new BaryonicNodeContext(cosmicWeb)));
        }

        int darkMatterNodeCount = GetDarkMatterNodeCount(context);
        for (int i = 0; i < darkMatterNodeCount; i++)
        {
            cosmicWeb.DarkMatterNodes.Add(_darkMatterNodeGenerator.Generate(new DarkMatterNodeContext(cosmicWeb)));
        }

        int baryonicVoidCount = GetBaryonicVoidCount(context);
        for (int i = 0; i < baryonicVoidCount; i++)
        {
            cosmicWeb.BaryonicVoids.Add(_baryonicVoidGenerator.Generate(new BaryonicVoidContext(cosmicWeb)));
        }

        int darkMatterVoidCount = GetDarkMatterVoidCount(context);
        for (int i = 0; i < darkMatterVoidCount; i++)
        {
            cosmicWeb.DarkMatterVoids.Add(_darkMatterVoidGenerator.Generate(new DarkMatterVoidContext(cosmicWeb)));
        }

        return cosmicWeb;
    }

    public int GetBaryonicFilamentCount(CosmicWebContext context)
    {
        const int BASE_COUNT = 100;

        var sizeFactor = Math.Max(0.1, context.Size / 1000.0);
        var ageFactor = Math.Max(0.1, context.Age / 100.0);

        var darkMatterEffect = context.DarkMatterPercent / 100.0;  // Normalize to [0, 1] range
        var darkEnergyEffect = context.DarkEnergyPercent / 100.0;  // Normalize to [0, 1] range
        var energyFactor = darkMatterEffect * (1 - darkEnergyEffect);  // Interaction where high dark energy reduces the effect of dark matter

        var averageExpansionRate = 70.0;  // Assumed average in km/s/Mpc
        var expansionRatio = context.ExpansionRate / averageExpansionRate;
        var expansionFactor = 1.0 / expansionRatio;  // Faster expansion results in a lower factor, slower expansion results in a higher factor

        var count = (int)(BASE_COUNT * sizeFactor * ageFactor * energyFactor * expansionFactor);
        var randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);
        count = (int)(count * randomFactor);

        return count;
    }



    public CosmicWebGenerator(GeneratorConfig config) : base(config)
    {
        _baryonicFilamentGenerator = new BaryonicFilamentGenerator(config);
        _darkMatterFilamentGenerator = new DarkMatterFilamentGenerator(config);
        _baryonicNodeGenerator = new BaryonicNodeGenerator(config);
        _darkMatterNodeGenerator = new DarkMatterNodeGenerator(config);
        _baryonicVoidGenerator = new BaryonicVoidGenerator(config);
        _darkMatterVoidGenerator = new DarkMatterVoidGenerator(config);
    }
}