using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidStructureGenerator : VoidStructureGenerator<BaryonicMatterVoidStructure, BaryonicMatterVoidStructureContext>
{
    public BaryonicMatterVoidStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
        Enabled = ObjectToggles.BaryonicMatterVoidStructureEnabled;
    }

    protected override async Task GenerateChildren(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        var baryonicMatterVoidContext = new BaryonicMatterVoidContext
        {
            DiameterCreateRange = ConfigurationService.GetConfiguration<BaryonicMatterVoidSettings>().DiameterRange,
            RandomizationAlgorithm = ConfigurationService.GetConfiguration<CosmicWebSettings>().RandomGenerationAlgorithm,
        };
        var baryonicMatterVoidGenerator = new BaryonicMatterVoidGenerator(EventAggregator, GeneratorInvokerService, ConfigurationService);

        var volumeSize = ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.X * ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.Y * ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.Z;
        var targetTotalVoidVolume = volumeSize * self.VolumeCoveredByPercent / 100;
        var totalVoidVolume = 0d;

        while (totalVoidVolume < targetTotalVoidVolume)
        {
            var newBaryonicMatterVoid = await baryonicMatterVoidGenerator.Generate(baryonicMatterVoidContext, self.Parent);
            baryonicMatterVoidContext.PositionXCreateRange = new VNet.Configuration.Range<float>(0f, ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.X - newBaryonicMatterVoid.Diameter);
            baryonicMatterVoidContext.PositionYCreateRange = new VNet.Configuration.Range<float>(0f, ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.Y - newBaryonicMatterVoid.Diameter);
            baryonicMatterVoidContext.PositionZCreateRange = new VNet.Configuration.Range<float>(0f, ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.Z - newBaryonicMatterVoid.Diameter);
            baryonicMatterVoidGenerator.GeneratePosition(baryonicMatterVoidContext, newBaryonicMatterVoid);

            var acceptableOverlap = false;
            while (!acceptableOverlap)
            {
                var overlapAmount = CalculateOverlapAmount(newBaryonicMatterVoid, self.BaryonicMatterVoids);
                if (!ConfigurationService.GetConfiguration<BaryonicMatterVoidStructureSettings>().OverlapRange.IsInRange(overlapAmount) ||
                    self.BaryonicMatterVoids.Count(x =>
                        CalculateOverlapAmount(newBaryonicMatterVoid, new List<BaryonicMatterVoid> { x }) > 0) / (float)self.BaryonicMatterVoids.Count > self.OverlappingPercent)
                {
                    baryonicMatterVoidContext.PositionXCreateRange = new VNet.Configuration.Range<float>(0, ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.X - newBaryonicMatterVoid.Diameter);
                    baryonicMatterVoidContext.PositionYCreateRange = new VNet.Configuration.Range<float>(0, ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.Y - newBaryonicMatterVoid.Diameter);
                    baryonicMatterVoidContext.PositionZCreateRange = new VNet.Configuration.Range<float>(0, ConfigurationService.GetConfiguration<BasicSettings>().MapDimensions.Z - newBaryonicMatterVoid.Diameter);
                    baryonicMatterVoidGenerator.GeneratePosition(baryonicMatterVoidContext, newBaryonicMatterVoid);
                }
                else
                {
                    acceptableOverlap = true;
                }
            }

            self.BaryonicMatterVoids.Add(newBaryonicMatterVoid);
            totalVoidVolume += newBaryonicMatterVoid.Volume;
        }
    }

    protected override void GenerateInteriorObjects(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.InteriorObjects = new List<IUndefinedAstronomicalObject>();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.InteriorRandomizationAlgorithm = null;
    }

    protected override async Task<BaryonicMatterVoidStructure> GenerateSelf(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.VolumeCoveredByPercent = self.RandomGenerationAlgorithm.NextSingleInclusive(ConfigurationService.GetConfiguration<BaryonicMatterVoidStructureSettings>().VolumeCoveredByPercentRange);
        self.OverlappingPercent = self.RandomGenerationAlgorithm.NextSingleInclusive(ConfigurationService.GetConfiguration<BaryonicMatterVoidStructureSettings>().OverlappingPercentRange);

        return self;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.SurfaceNoiseAlgorithm = null;
    }

    protected override void GenerateWarpedSurface(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.WarpedSurface = new List<Vector3>();
    }

    protected override void SetMatterType(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.MatterType = MatterType.BaryonicMatter;
    }

    internal override void AssignChildren(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        self.Children.AddRange(self.BaryonicMatterVoids);
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }
}