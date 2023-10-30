using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : VoidGeneratorBase<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<BaryonicMatterVoidGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override async Task GenerateChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        var numGalaxyGroups = self.RandomGenerationAlgorithm.NextInclusive(0, 10);
        for (var i = 0; i < numGalaxyGroups; i++)
        {
            var galaxyGroupContext = new GalaxyGroupContext(self);
            var newGalaxyGroup = await GeneratorInvokerService.Generate<GalaxyGroup, GalaxyGroupContext>(galaxyGroupContext, self);
            self.GalaxyGroups.Add(newGalaxyGroup);
        }

        var numGalaxies = self.RandomGenerationAlgorithm.NextInclusive(0, 10);
        for (var i = 0; i < numGalaxies; i++)
        {
            var galaxyContext = new GalaxyContext(self);
            var newGalaxy = await GeneratorInvokerService.Generate<Galaxy, GalaxyContext>(galaxyContext, self);

            self.Galaxies.Add(newGalaxy);
        }

        var numVoidGalaxies = self.RandomGenerationAlgorithm.NextInclusive(0, 10);
        for (var i = 0; i < numVoidGalaxies; i++)
        {
            var voidGalaxyContext = new VoidGalaxyContext(self);
            var newVoidGalaxy = await GeneratorInvokerService.Generate<VoidGalaxy, VoidGalaxyContext>(voidGalaxyContext, self);

            self.VoidGalaxies.Add(newVoidGalaxy);
        }
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.InteriorRandomizationAlgorithm = context.InteriorObjectRandomizationAlgorithm;
    }

    protected override async Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        return self;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.SurfaceNoiseAlgorithm = context.SurfaceWarpingNoiseAlgorithm;
    }

    protected override void SetMatterType(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.MatterType = MatterType.BaryonicMatter;
    }

    internal override void AssignChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.Children.AddRange(self.GalaxyGroups);
        self.Children.AddRange(self.Galaxies);
        self.Children.AddRange(self.VoidGalaxies);
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }
}