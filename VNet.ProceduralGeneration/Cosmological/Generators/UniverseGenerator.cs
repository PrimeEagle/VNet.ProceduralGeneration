using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

#pragma warning disable IDE0060
// ReSharper disable UnusedParameter.Local

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class UniverseGenerator : GroupGeneratorBase<Universe, UniverseContext>
{
    public UniverseGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        Enabled = ObjectToggles.UniverseEnabled;
    }

    protected override async Task<Universe> GenerateSelf(UniverseContext context, Universe self)
    {
        GenerateBaryonicMatterPercent(context, self);
        GenerateDarkMatterPercent(context, self);
        GenerateDarkEnergyPercent(context, self);
        GenerateConnectivityFactor(context, self);
        GenerateCurvature(context, self);
        GenerateCosmicMicrowaveBackground(context, self);
        RebalanceMatterEnergyPercentages(context, self);

        return self;
    }

    protected override async Task GenerateChildren(UniverseContext context, Universe self)
    {
        var cosmicWebGenerator = new CosmicWebGenerator(EventAggregator);
        var cosmicWebContext = new CosmicWebContext(self);

        self.CosmicWeb = await Task.Run(() => cosmicWebGenerator.Generate(cosmicWebContext, self));
    }

    protected override void SetMatterType(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    private static void RebalanceMatterEnergyPercentages(UniverseContext context, Universe self)
    {
        var sum = self.DarkEnergyPercent + self.DarkMatterPercent + self.BaryonicMatterPercent;
        self.DarkEnergyPercent = self.DarkEnergyPercent / sum * 100;
        self.DarkMatterPercent = self.DarkMatterPercent / sum * 100;
        self.BaryonicMatterPercent = 100 - self.DarkEnergyPercent - self.DarkMatterPercent;
    }

    private void GenerateCosmicMicrowaveBackground(UniverseContext context, Universe self)
    {
        self.CosmicMicrowaveBackground = AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingleInclusive(AdvancedSettings.Objects.CosmicWeb.CosmicMicrowaveBackgroundRange);
    }

    private void GenerateBaryonicMatterPercent(UniverseContext context, Universe self)
    {
        self.BaryonicMatterPercent = AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingleInclusive(BasicSettings.BaryonicMatterPercentRange);
    }

    private void GenerateDarkMatterPercent(UniverseContext context, Universe self)
    {
        self.DarkMatterPercent = AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingleInclusive(BasicSettings.DarkMatterPercentRange);
    }

    private void GenerateDarkEnergyPercent(UniverseContext context, Universe self)
    {
        self.DarkEnergyPercent = AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingleInclusive(BasicSettings.DarkEnergyPercentRange);
    }

    private void GenerateConnectivityFactor(UniverseContext context, Universe self)
    {
        self.ConnectivityFactor = AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextSingleInclusive(AdvancedSettings.Objects.Universe.ConnectivityFactorRange);
    }

    private void GenerateCurvature(UniverseContext context, Universe self)
    {
        if (self.InflationOccurred)
        {
            self.Curvature = CurvatureType.Flat;
        }
        else
        {
            var flatVal = AdvancedSettings.Objects.Universe.CurvatureFlatPercentage / 100;
            var sphericalVal = flatVal + AdvancedSettings.Objects.Universe.CurvatureSphericalPercentage / 100;

            var randValue = AdvancedSettings.Objects.Universe.RandomGenerationAlgorithm.NextDouble();

            if (randValue < flatVal)
                self.Curvature = CurvatureType.Flat;
            else if (randValue < sphericalVal)
                self.Curvature = CurvatureType.Spherical;
            else
                self.Curvature = CurvatureType.Hyperbolic;
        }
    }

    protected override void GenerateWarpedSurface(UniverseContext context, Universe self)
    {
        self.WarpedSurface = new List<Vector3>();   
    }

    protected override void GenerateInteriorObjects(UniverseContext context, Universe self)
    {
        self.InteriorObjects = new List<IUndefinedAstronomicalObject>();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(UniverseContext context, Universe self)
    {
        self.InteriorRandomizationAlgorithm = null;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(UniverseContext context, Universe self)
    {
        self.SurfaceNoiseAlgorithm = null;
    }

    protected override void GenerateBaseProperties(UniverseContext context, Universe self)
    {
        base.GenerateBaseProperties(context, self);

        GenerateCosmicMicrowaveBackground(context, self);
        GenerateBaryonicMatterPercent(context, self);
        GenerateDarkMatterPercent(context, self);
        GenerateDarkEnergyPercent(context, self);
        GenerateConnectivityFactor(context, self);
        GenerateCurvature(context, self);
        GenerateAge(context, self);
        GenerateLifespan(context, self);
    }

    internal override void AssignChildren(UniverseContext context, Universe self)
    {
        self.Children.Add(self.CosmicWeb);
    }
}