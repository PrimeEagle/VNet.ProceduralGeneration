namespace VNet.ProceduralGeneration.Cosmological;

public class CosmicWebGenerator : BaseGenerator<CosmicWeb, CosmicWebContext>
{
    private readonly IntergalacticMediumGenerator _intergalacticMediumGenerator;
    private readonly BaryonicFilamentGenerator _baryonicFilamentGenerator;
    private readonly DarkMatterFilamentGenerator _darkMatterFilamentGenerator;
    private readonly BaryonicNodeGenerator _baryonicNodeGenerator;
    private readonly DarkMatterNodeGenerator _darkMatterNodeGenerator;
    private readonly BaryonicVoidGenerator _baryonicVoidGenerator;
    private readonly DarkMatterVoidGenerator _darkMatterVoidGenerator;
    private readonly BaryonicSheetGenerator _baryonicSheetGenerator;
    private readonly DarkMatterSheetGenerator _darkMatterSheetGenerator;


    public override CosmicWeb Generate(CosmicWebContext context)
    {
        var cosmicWeb = new CosmicWeb();

        Parallel.For(0, GetBaryonicFilamentCount(context), i =>
        {
            var baryonicFilament = _baryonicFilamentGenerator.Generate(new BaryonicFilamentContext(cosmicWeb));
            cosmicWeb.BaryonicFilaments.Add(baryonicFilament);
        });

        Parallel.For(0, GetDarkMatterFilamentCount(context), i =>
        {
            var darkMatterFilament = _darkMatterFilamentGenerator.Generate(new DarkMatterFilamentContext(cosmicWeb));
            cosmicWeb.DarkMatterFilaments.Add(darkMatterFilament);
        });

        Parallel.For(0, GetBaryonicNodeCount(context), i =>
        {
            var baryonicNode = _baryonicNodeGenerator.Generate(new BaryonicNodeContext(cosmicWeb));
            cosmicWeb.BaryonicNodes.Add(baryonicNode);
        });

        Parallel.For(0, GetDarkMatterNodeCount(context), i =>
        {
            var darkMatterNode = _darkMatterNodeGenerator.Generate(new DarkMatterNodeContext(cosmicWeb));
            cosmicWeb.DarkMatterNodes.Add(darkMatterNode);
        });

        Parallel.For(0, GetBaryonicVoidCount(context), i =>
        {
            var baryonicVoid = _baryonicVoidGenerator.Generate(new BaryonicVoidContext(cosmicWeb));
            cosmicWeb.BaryonicVoids.Add(baryonicVoid);
        });

        Parallel.For(0, GetDarkMatterVoidCount(context), i =>
        {
            var darkMatterVoid = _darkMatterVoidGenerator.Generate(new DarkMatterVoidContext(cosmicWeb));
            cosmicWeb.DarkMatterVoids.Add(darkMatterVoid);
        });

        Parallel.For(0, GetBaryonicSheetCount(context), i =>
        {
            var baryonicSheet = _baryonicSheetGenerator.Generate(new BaryonicSheetContext(cosmicWeb));
            cosmicWeb.BaryonicSheets.Add(baryonicSheet);
        });

        Parallel.For(0, GetDarkMatterSheetCount(context), i =>
        {
            var darkMatterSheet = _darkMatterSheetGenerator.Generate(new DarkMatterSheetContext(cosmicWeb));
            cosmicWeb.DarkMatterSheets.Add(darkMatterSheet);
        });

        var intergalacticMediumContext = new IntergalacticMediumContext();
        var imgTask = Task.Run(() => _intergalacticMediumGenerator.Generate(intergalacticMediumContext));

        Task.WaitAll(imgTask);

        cosmicWeb.IntergalacticMedium = imgTask.Result;

        PostProcess();

        return cosmicWeb;
    }

    private void PostProcess()
    {

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

    public int GetDarkMatterFilamentCount(CosmicWebContext context)
    {
        const int BASE_COUNT = 120;  // Assuming a slightly higher base for dark matter filaments due to their dominant structural role

        var sizeFactor = Math.Max(0.1, context.Size / 1000.0);
        var ageFactor = Math.Max(0.1, context.Age / 100.0);

        var darkMatterEffect = context.DarkMatterPercent / 100.0;  // Normalize to [0, 1] range
        var darkEnergyEffect = context.DarkEnergyPercent / 100.0;  // Normalize to [0, 1] range
        var energyFactor = Math.Pow(darkMatterEffect, 1.5) * (1 - darkEnergyEffect);  // Exponential dependence on dark matter with dampening by dark energy

        var averageExpansionRate = 70.0;  // Assumed average in km/s/Mpc
        var expansionRatio = context.ExpansionRate / averageExpansionRate;
        var expansionFactor = 1.0 / expansionRatio;  // Faster expansion results in a lower factor, slower expansion results in a higher factor

        var count = (int)(BASE_COUNT * sizeFactor * ageFactor * energyFactor * expansionFactor);
        var randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);
        count = (int)(count * randomFactor);

        return count;
    }

    public int GetBaryonicNodeCount(CosmicWebContext context)
    {
        const int BASE_NODE_COUNT = 50; // This is an arbitrary base number; adjust based on your needs.

        // The more filaments, the more intersections and hence more nodes.
        double filamentFactor = Math.Max(0.1, GetBaryonicFilamentCount(context) / 100.0);

        // Nodes likely formed over time, so a more mature universe might have more.
        double ageFactor = Math.Max(0.1, context.Age / 100.0);

        // Baryonic matter concentration might influence node formation.
        double baryonicFactor = Math.Max(0.1, context.BaryonicMatterPercent / 100.0);

        // Expansion rate might affect the density and hence the node formations. 
        // If expansion is too fast, it might prevent denser nodes from forming.
        double expansionFactor = 1 / (1 + context.ExpansionRate / 1000); // This is a basic inverse relationship. Adjust as needed.

        int count = (int)(BASE_NODE_COUNT * filamentFactor * ageFactor * baryonicFactor * expansionFactor);

        // A random factor for some variability.
        double randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);
        count = (int)(count * randomFactor);

        return count;
    }

    public int GetDarkMatterNodeCount(CosmicWebContext context)
    {
        const int BASE_DARK_MATTER_NODE_COUNT = 70;  // This is an arbitrary base number, you might find you need to adjust based on your needs.

        // Dark matter filaments will influence the dark matter nodes. More filaments, more intersections.
        double darkMatterFilamentFactor = Math.Max(0.1, GetDarkMatterFilamentCount(context) / 100.0);

        // Age would still play a role; older universes might have more intersections formed.
        double ageFactor = Math.Max(0.1, context.Age / 100.0);

        // Dark matter concentration would play a direct role in dark matter node formation.
        double darkMatterFactor = Math.Max(0.1, context.DarkMatterPercent / 100.0);

        // Expansion rate might affect the density and thus node formations, similar to baryonic nodes.
        double expansionFactor = 1 / (1 + context.ExpansionRate / 1000); // Adjust the denominator as needed.

        int count = (int)(BASE_DARK_MATTER_NODE_COUNT * darkMatterFilamentFactor * ageFactor * darkMatterFactor * expansionFactor);

        // Incorporate randomness for variability.
        double randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);
        count = (int)(count * randomFactor);

        return count;
    }

    public int GetBaryonicVoidCount(CosmicWebContext context)
    {
        const int BASE_BARYONIC_VOID_COUNT = 50;  // This is an arbitrary base number.

        // More nodes and filaments might lead to more defined voids.
        double structureFactor = (GetBaryonicNodeCount(context) + GetBaryonicFilamentCount(context)) / 200.0;

        // Age factor; older universes might have more defined void regions.
        double ageFactor = context.Age / 100.0;

        // Expansion rate might affect the size and count of voids.
        double expansionFactor = 1 + (context.ExpansionRate / 5000); // Adjust the denominator as needed.

        int count = (int)(BASE_BARYONIC_VOID_COUNT * structureFactor * ageFactor / expansionFactor);

        // Incorporate randomness.
        double randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);
        count = (int)(count * randomFactor);

        return count;
    }

    public int GetDarkMatterVoidCount(CosmicWebContext context)
    {
        const int BASE_DARK_MATTER_VOID_COUNT = 60;  // A starting point; might need adjustments.

        // More dark matter nodes and filaments lead to more defined voids.
        double structureFactor = (GetDarkMatterNodeCount(context) + GetDarkMatterFilamentCount(context)) / 200.0;

        // Age factor; older universes might have more defined void regions, especially for dark matter.
        double ageFactor = Math.Pow(context.Age / 100.0, 1.5);  // Dark matter structures early, hence the exponent.

        // Expansion rate's effect.
        double expansionFactor = 1 + (context.ExpansionRate / 5000);  // Adjust denominator as needed.

        int count = (int)(BASE_DARK_MATTER_VOID_COUNT * structureFactor * ageFactor / expansionFactor);

        // Random variability.
        double randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);
        count = (int)(count * randomFactor);

        return count;
    }

    public int GetBaryonicSheetCount(CosmicWebContext context)
    {
        const int BASE_COUNT = 50;  // Base count for sheets, assuming they're somewhat less frequent than filaments

        // Age Factor: Younger universes might have less-defined structures.
        double ageFactor = Math.Max(0.1, context.Age / 10.0);  // Assuming Universe max age is 10 units.

        // Size Factor: A larger universe can contain more structures.
        double sizeFactor = Math.Max(0.1, context.Size / 1000.0);  // Assuming Universe max size is 1000 units.

        // Expansion Factor: Faster expansion can inhibit structure formation.
        double expansionFactor = 1 - (Math.Min(context.ExpansionRate, 100) / 100.0);  // Assuming 100 km/s/Mpc is a high rate.

        // Dark Matter Factor: More dark matter would encourage more structure.
        double darkMatterFactor = context.DarkMatterPercent / 100.0;

        // Energy Factor: Considering that higher dark energy might inhibit structure formation.
        double energyFactor = 1 - (context.DarkEnergyPercent / 100.0);

        // Calculate total count based on above factors.
        int count = (int)(BASE_COUNT * ageFactor * sizeFactor * expansionFactor * darkMatterFactor * energyFactor);

        // Introducing some random variability in count for naturalness.
        double randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);  // +/-10% variability
        count = (int)(count * randomFactor);

        return count;
    }

    public int GetDarkMatterSheetCount(CosmicWebContext context)
    {
        const int BASE_COUNT = 60;  // Starting with a slightly higher base count than baryonic sheets.

        // Age Factor: Younger universes might have less defined structures.
        double ageFactor = Math.Max(0.1, context.Age / 10.0);  // Assuming Universe max age is 10 units.

        // Size Factor: A larger universe can contain more structures.
        double sizeFactor = Math.Max(0.1, context.Size / 1000.0);  // Assuming Universe max size is 1000 units.

        // Expansion Factor: Faster expansion can inhibit structure formation but might not affect dark matter as much.
        double expansionFactor = 1 - (0.5 * Math.Min(context.ExpansionRate, 100) / 100.0);  // Half the effect of baryonic matter.

        // Dark Matter Factor: Higher weight since it's dark matter sheets. More dark matter would encourage more structure.
        double darkMatterFactor = (context.DarkMatterPercent / 100.0) * 1.5;  // Weighting this 50% more than baryonic.

        // Energy Factor: Considering that higher dark energy might inhibit structure formation but with less effect on dark matter.
        double energyFactor = 1 - (0.5 * context.DarkEnergyPercent / 100.0);  // Half the effect of baryonic matter.

        // Calculate total count based on above factors.
        int count = (int)(BASE_COUNT * ageFactor * sizeFactor * expansionFactor * darkMatterFactor * energyFactor);

        // Introducing some random variability in count for naturalness.
        double randomFactor = 1 + (config.RandomGenerator.NextDouble() * 0.2 - 0.1);  // +/-10% variability
        count = (int)(count * randomFactor);

        return count;
    }

    public CosmicWebGenerator(GeneratorConfig config) : base(config)
    {
        _intergalacticMediumGenerator = new IntergalacticMediumGenerator(config);
        _baryonicFilamentGenerator = new BaryonicFilamentGenerator(config);
        _darkMatterFilamentGenerator = new DarkMatterFilamentGenerator(config);
        _baryonicNodeGenerator = new BaryonicNodeGenerator(config);
        _darkMatterNodeGenerator = new DarkMatterNodeGenerator(config);
        _baryonicVoidGenerator = new BaryonicVoidGenerator(config);
        _darkMatterVoidGenerator = new DarkMatterVoidGenerator(config);
        _baryonicSheetGenerator = new BaryonicSheetGenerator(config);
        _darkMatterSheetGenerator = new DarkMatterSheetGenerator(config);
    }
}