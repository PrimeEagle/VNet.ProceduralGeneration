using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;
// ReSharper disable UnusedParameter.Local

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class UniverseGenerator : ContainerGeneratorBase<Universe, UniverseContext>
{
    public UniverseGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        enabled = ObjectToggles.UniverseEnabled;
    }

    protected override void GenerateTemperature(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    protected override async Task<Universe> GenerateSelf(UniverseContext context, Universe self)
    {
        GenerateBaryonicMatterPercent(context, self);
        GenerateDarkMatterPercent(context, self);
        GenerateDarkEnergyPercent(context, self);
        GenerateConnectivityFactor(context, self);
        GenerateCurvature(context, self);
        GenerateCosmicMicrowaveBackground(context, self);
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

    private void GenerateCosmicMicrowaveBackground(UniverseContext context, Universe self)
    {
        self.CosmicMicrowaveBackground = AdvancedSettings.Universe.RandomGenerator.NextSingle(AdvancedSettings.Universe.MinCosmicMicrowaveBackground, AdvancedSettings.Universe.MaxCosmicMicrowaveBackground);
    }

    private void GenerateBaryonicMatterPercent(UniverseContext context, Universe self)
    {
        self.BaryonicMatterPercent = AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinBaryonicMatterPercent, BasicSettings.MaxBaryonicMatterPercent);
    }

    private void GenerateDarkMatterPercent(UniverseContext context, Universe self)
    {
        self.DarkMatterPercent = AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinDarkMatterPercent, BasicSettings.MaxDarkMatterPercent);
    }

    private void GenerateDarkEnergyPercent(UniverseContext context, Universe self)
    {
        self.DarkEnergyPercent = AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinDarkEnergyPercent, BasicSettings.MaxDarkEnergyPercent);
    }

    private void GenerateConnectivityFactor(UniverseContext context, Universe self)
    {
        self.ConnectivityFactor = AdvancedSettings.Universe.RandomGenerator.NextSingle(AdvancedSettings.Universe.MinConnectivityFactor, AdvancedSettings.Universe.MaxConnectivityFactor);
    }

    private void GenerateCurvature(UniverseContext context, Universe self)
    {
        if (self.InflationOccurred)
        {
            self.Curvature = CurvatureType.Flat;
        }
        else
        {
            var flatVal = AdvancedSettings.Universe.CurvatureFlatPercentage / 100;
            var sphericalVal = flatVal + AdvancedSettings.Universe.CurvatureSphericalPercentage / 100;

            var randValue = AdvancedSettings.Universe.RandomGenerator.NextDouble();

            if (randValue < flatVal)
            {
                self.Curvature = CurvatureType.Flat;
            }
            else if (randValue < sphericalVal)
            {
                self.Curvature = CurvatureType.Spherical;
            }
            else
            {
                self.Curvature = CurvatureType.Hyperbolic;
            }
        }
    }

    protected override void GenerateAge(UniverseContext context, Universe self)
    {
        self.Age = AdvancedSettings.Universe.RandomGenerator.NextSingle(BasicSettings.MinUniverseAge, BasicSettings.MaxUniverseAge);
    }

    protected override void GenerateLifespan(UniverseContext context, Universe self)
    {
        self.Lifespan = float.MaxValue;
    }

    protected override void GenerateDiameter(UniverseContext context, Universe self)
    {
        self.Diameter = Settings.Basic.AverageDimension;
    }

    protected override void GeneratePosition(UniverseContext context, Universe self)
    {
        self.Position = new Vector3(0, 0, 0);
    }

    protected override void GenerateBaseProperties(UniverseContext context, Universe self)
    {
        base.GenerateBaseProperties(context, self);
        GenerateAge(context, self);
        GenerateLifespan(context, self);
    }
}