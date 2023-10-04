using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class UniverseGenerator : GeneratorBase<Universe, UniverseContext>
{
    public UniverseGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        enabled = ObjectToggles.UniverseEnabled;
    }

    protected override async Task<Universe> GenerateSelf(UniverseContext context, Universe self)
    {
        self.DarkEnergyPercent = AdvancedSettings.Universe.RandomGenerator.NextDouble(BasicSettings.MinDarkEnergyPercent, BasicSettings.MaxDarkEnergyPercent);
        self.DarkMatterPercent = AdvancedSettings.Universe.RandomGenerator.NextDouble(BasicSettings.MinDarkMatterPercent, BasicSettings.MaxDarkMatterPercent);
        self.BaryonicMatterPercent = AdvancedSettings.Universe.RandomGenerator.NextDouble(BasicSettings.MinBaryonicMatterPercent, BasicSettings.MaxBaryonicMatterPercent);
        self.ConnectivityFactor = AdvancedSettings.Universe.RandomGenerator.NextDouble(AdvancedSettings.Universe.MinConnectivityFactor, AdvancedSettings.Universe.MaxConnectivityFactor);
        self.Position = new Vector3(0, 0, 0);


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

        var sum = self.DarkEnergyPercent + self.DarkMatterPercent + self.BaryonicMatterPercent;
        self.DarkEnergyPercent = (self.DarkEnergyPercent / sum) * 100;
        self.DarkMatterPercent = (self.DarkMatterPercent / sum) * 100;
        self.BaryonicMatterPercent = 100 - self.DarkEnergyPercent - self.DarkMatterPercent;
        self.ApplyInflationEffects();

        return self;
    }

    protected override async Task GenerateChildren(UniverseContext context, Universe self)
    {
        var cosmicWebGenerator = new CosmicWebGenerator(this.eventAggregator);
        var cosmicWebContext = new CosmicWebContext(self);

        self.CosmicWeb = await Task.Run(() => cosmicWebGenerator.Generate(cosmicWebContext, self));
    }

    protected override Task PostProcess(UniverseContext context, Universe self)
    {
        return null;
    }

    protected override float GenerateAge(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }
    
    protected override double GenerateMass(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateDiameter(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLuminosity(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(UniverseContext context, Universe self)
    {
        throw new NotImplementedException();
    }
}