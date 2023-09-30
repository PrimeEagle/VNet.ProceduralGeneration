using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class UniverseGenerator : BaseGenerator<Universe, UniverseContext>
{
    private readonly CosmicWebGenerator _cosmicWebGenerator;


    public UniverseGenerator() : base(ParallelismLevel.Level0)
    {
        _cosmicWebGenerator = new CosmicWebGenerator();
    }

    public override async Task<Universe> Generate(UniverseContext context)
    {
        return await ExecuteWithConcurrencyControlAsync(() => GenerateUniverse(context));
    }

    private async Task<Universe> GenerateUniverse(UniverseContext context)
    {
        if(!ObjectToggles.UniverseEnabled) { return new Universe(); }

        var universe = new Universe
        {
            Age = AdvancedSettings.RandomGenerator.NextSingle(BasicSettings.MinUniverseAge, BasicSettings.MaxUniverseAge),
            DarkEnergyPercent = AdvancedSettings.RandomGenerator.NextDouble(BasicSettings.MinDarkEnergyPercent, BasicSettings.MaxDarkEnergyPercent),
            DarkMatterPercent = AdvancedSettings.RandomGenerator.NextDouble(BasicSettings.MinDarkMatterPercent, BasicSettings.MaxDarkMatterPercent),
            BaryonicMatterPercent = AdvancedSettings.RandomGenerator.NextDouble(BasicSettings.MinBaryonicMatterPercent, BasicSettings.MaxBaryonicMatterPercent),
            ConnectivityFactor = AdvancedSettings.RandomGenerator.NextDouble(AdvancedSettings.MinConnectivityFactor, AdvancedSettings.MaxConnectivityFactor),
            Position = new Vector3(0, 0, 0)
        };

        var randValue = AdvancedSettings.RandomGenerator.NextDouble();
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