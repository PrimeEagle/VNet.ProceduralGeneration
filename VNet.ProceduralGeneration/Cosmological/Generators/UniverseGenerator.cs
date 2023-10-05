using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;
// ReSharper disable UnusedParameter.Local

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class UniverseGenerator : GeneratorBase<Universe, UniverseContext>
{
    public UniverseGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        enabled = ObjectToggles.UniverseEnabled;
    }

    protected override async Task<Universe> GenerateSelf(UniverseContext context, Universe self)
    {
        self.BaryonicMatterPercent = GenerateBaryonicMatterPercent(context, self);
        self.DarkMatterPercent = GenerateDarkMatterPercent(context, self);
        self.DarkEnergyPercent = GenerateDarkEnergyPercent(context, self);
        self.ConnectivityFactor = GenerateConnectivityFactor(context, self);
        self.Curvature = GenerateCurvature(context, self);
        self.CosmicMicrowaveBackground = GenerateCosmicMicrowaveBackground(context, self);
        RebalancePercentages(context, self);

        return self;
    }

    protected override async Task GenerateChildren(UniverseContext context, Universe self)
    {
        var cosmicWebGenerator = new CosmicWebGenerator(this.EventAggregator);
        var cosmicWebContext = new CosmicWebContext(self);

        self.CosmicWeb = await Task.Run(() => cosmicWebGenerator.Generate(cosmicWebContext, self));
    }

    protected override Task PostProcess(UniverseContext context, Universe self)
    {
        return null;
    }

    private static void RebalancePercentages(UniverseContext context, Universe self)
    {
        var sum = self.DarkEnergyPercent + self.DarkMatterPercent + self.BaryonicMatterPercent;
        self.DarkEnergyPercent = (self.DarkEnergyPercent / sum) * 100;
        self.DarkMatterPercent = (self.DarkMatterPercent / sum) * 100;
        self.BaryonicMatterPercent = 100 - self.DarkEnergyPercent - self.DarkMatterPercent;
    }

    private float GenerateCosmicMicrowaveBackground(UniverseContext context, Universe self)
    {
        return AdvancedSettings.Universe.RandomGenerator.NextSingle(AdvancedSettings.Universe.MinCosmicMicrowaveBackground, AdvancedSettings.Universe.MaxCosmicMicrowaveBackground);
    }

    private float GenerateBaryonicMatterPercent(UniverseContext context, Universe self)
    {
        return AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinBaryonicMatterPercent, BasicSettings.MaxBaryonicMatterPercent);
    }

    private float GenerateDarkMatterPercent(UniverseContext context, Universe self)
    {
        return AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinDarkMatterPercent, BasicSettings.MaxDarkMatterPercent);
    }

    private float GenerateDarkEnergyPercent(UniverseContext context, Universe self)
    {
        return AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinDarkEnergyPercent, BasicSettings.MaxDarkEnergyPercent);
    }

    private float GenerateConnectivityFactor(UniverseContext context, Universe self)
    {
        return AdvancedSettings.Universe.RandomGenerator.NextSingle(AdvancedSettings.Universe.MinConnectivityFactor, AdvancedSettings.Universe.MaxConnectivityFactor);
    }

    private CurvatureType GenerateCurvature(UniverseContext context, Universe self)
    {
        if (self.InflationOccurred)
        {
            return CurvatureType.Flat;
        }
        else
        {
            var flatVal = AdvancedSettings.Universe.CurvatureFlatPercentage / 100;
            var sphericalVal = flatVal + AdvancedSettings.Universe.CurvatureSphericalPercentage / 100;

            var randValue = AdvancedSettings.Universe.RandomGenerator.NextDouble();

            if (randValue < flatVal)
            {
                return CurvatureType.Flat;
            }
            else if (randValue < sphericalVal)
            {
                return CurvatureType.Spherical;
            }
            else
            {
                return CurvatureType.Hyperbolic;
            }
        }
    }

    protected override float GenerateAge(UniverseContext context, Universe self)
    {
        return AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinUniverseAge, BasicSettings.MaxUniverseAge);
    }
    
    protected override double GenerateMass(UniverseContext context, Universe self)
    {
        return self.Children.Sum(c => c.Mass);
    }

    protected override float GenerateDiameter(UniverseContext context, Universe self)
    {
        return Settings.Basic.AverageDimension;
    }

    protected override float GenerateLuminosity(UniverseContext context, Universe self)
    {
        return self.Children.Sum(c => c.Luminosity);
    }

    protected override float GenerateAbsoluteMagnitude(UniverseContext context, Universe self)
    {
        return (float)(-2.5 * Math.Log10(self.Children.Sum(c => c.Luminosity)) + Settings.Advanced.PhysicalConstants.C);
    }

    protected override float GenerateTemperature(UniverseContext context, Universe self)
    {
        return self.Children.Sum(c => c.Luminosity * c.Temperature) / self.Children.Sum(c => c.Luminosity);
    }

    protected override float GenerateLifespan(UniverseContext context, Universe self)
    {
        return float.MaxValue;
    }

    protected override Vector3 GeneratePosition(UniverseContext context, Universe self)
    {
        return new Vector3(0, 0, 0);
    }
}