using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class UniverseGenerator : BaseGenerator<Universe, UniverseContext>
{
    public UniverseGenerator() : base(ParallelismLevel.Level0)
    {
        enabled = ObjectToggles.UniverseEnabled;
    }

    protected override async Task<Universe> GenerateSelf(UniverseContext context)
    {
        var universe = new Universe(null)
        {
            Age = AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinUniverseAge, BasicSettings.MaxUniverseAge),
            DarkEnergyPercent = AdvancedSettings.Universe.RandomGenerator.NextDouble(BasicSettings.MinDarkEnergyPercent, BasicSettings.MaxDarkEnergyPercent),
            DarkMatterPercent = AdvancedSettings.Universe.RandomGenerator.NextDouble(BasicSettings.MinDarkMatterPercent, BasicSettings.MaxDarkMatterPercent),
            BaryonicMatterPercent = AdvancedSettings.Universe.RandomGenerator.NextDouble(BasicSettings.MinBaryonicMatterPercent, BasicSettings.MaxBaryonicMatterPercent),
            ConnectivityFactor = AdvancedSettings.Universe.RandomGenerator.NextDouble(AdvancedSettings.Universe.MinConnectivityFactor, AdvancedSettings.Universe.MaxConnectivityFactor),
            Position = new Vector3(0, 0, 0)
        };


        var flatVal = AdvancedSettings.Universe.CurvatureFlatPercentage / 100;
        var sphericalVal = flatVal + AdvancedSettings.Universe.CurvatureSphericalPercentage / 100;

        var randValue = AdvancedSettings.Universe.RandomGenerator.NextDouble();

        if (randValue < flatVal)
        {
            universe.Curvature = CurvatureType.Flat;
        }
        else if (randValue < sphericalVal)
        {
            universe.Curvature = CurvatureType.Spherical;
        }
        else
        {
            universe.Curvature = CurvatureType.Hyperbolic;
        }

        var sum = universe.DarkEnergyPercent + universe.DarkMatterPercent + universe.BaryonicMatterPercent;
        universe.DarkEnergyPercent = (universe.DarkEnergyPercent / sum) * 100;
        universe.DarkMatterPercent = (universe.DarkMatterPercent / sum) * 100;
        universe.BaryonicMatterPercent = 100 - universe.DarkEnergyPercent - universe.DarkMatterPercent;
        universe.ApplyInflationEffects();

        return universe;
    }

    protected override async Task GenerateChildren(Universe self, UniverseContext context)
    {
        var cosmicWebGenerator = new CosmicWebGenerator();
        var cosmicWebContext = new CosmicWebContext(self);

        self.CosmicWeb = await Task.Run(() => cosmicWebGenerator.Generate(cosmicWebContext, self));
    }

    protected override Task PostProcess(Universe self, UniverseContext context)
    {
        return null;
    }
}