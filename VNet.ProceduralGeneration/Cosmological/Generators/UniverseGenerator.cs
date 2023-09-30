using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological;

public class UniverseGenerator : BaseGenerator<Universe, UniverseContext>
{
    private readonly CosmicWebGenerator _cosmicWebGenerator;


    public UniverseGenerator()
    {
        _cosmicWebGenerator = new CosmicWebGenerator();
    }

    public async override Task<Universe> Generate(UniverseContext context)
    {
        if(!objectToggles.UniverseEnabled) { return new Universe(); }

        var universe = new Universe
        {
            Age = advancedSettings.RandomGenerator.NextSingle(basicSettings.MinUniverseAge, basicSettings.MaxUniverseAge),
            DarkEnergyPercent = advancedSettings.RandomGenerator.NextDouble(basicSettings.MinDarkEnergyPercent, basicSettings.MaxDarkEnergyPercent),
            DarkMatterPercent = advancedSettings.RandomGenerator.NextDouble(basicSettings.MinDarkMatterPercent, basicSettings.MaxDarkMatterPercent),
            BaryonicMatterPercent = advancedSettings.RandomGenerator.NextDouble(basicSettings.MinBaryonicMatterPercent, basicSettings.MaxBaryonicMatterPercent),
            ConnectivityFactor = advancedSettings.RandomGenerator.NextDouble(advancedSettings.MinConnectivityFactor, advancedSettings.MaxConnectivityFactor),
            Position = new Vector3(0, 0, 0)
        };

        var randValue = advancedSettings.RandomGenerator.NextDouble();
        universe.Curvature = randValue switch
        {
            < 0.90 => CurvatureType.Flat,
            < 0.95 => CurvatureType.Spherical,
            _ => CurvatureType.Hyperbolic
        };

        var sum = universe.DarkEnergyPercent + universe.DarkMatterPercent + universe.BaryonicMatterPercent;
        universe.DarkEnergyPercent = (universe.DarkEnergyPercent / sum) * 100;
        universe.DarkMatterPercent = (universe.DarkMatterPercent / sum) * 100;
        universe.BaryonicMatterPercent = 100 - universe.DarkEnergyPercent - universe.DarkMatterPercent;
        universe.ApplyInflationEffects();

        var cosmicWebContext = new CosmicWebContext(universe);
        universe.CosmicWeb = await Task.Run(() => _cosmicWebGenerator.Generate(cosmicWebContext));

        PostProcess();

        return universe;
    }

    private void PostProcess()
    {

    }
}