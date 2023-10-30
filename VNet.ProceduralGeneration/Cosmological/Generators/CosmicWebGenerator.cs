using Microsoft.Extensions.Logging;
using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable PossibleLossOfFraction


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicWebGenerator : GroupGeneratorBase<CosmicWeb, CosmicWebContext>
{
    public CosmicWebGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<CosmicWebGenerator> loggerService, IAstronomicalObjectCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
        Enabled = ObjectToggles.CosmicWebEnabled;
    }

    protected override async Task GenerateChildren(CosmicWebContext context, CosmicWeb self)
    {
        var intergalacticMediumContext = new IntergalacticMediumContext(self);
        self.IntergalacticMedium = await GeneratorInvokerService.Generate<IntergalacticMedium, IntergalacticMediumContext>(intergalacticMediumContext, self);

        var baryonicMatterVoidStructureContext = new BaryonicMatterVoidStructureContext(self);
        self.BaryonicMatterVoidStructure = await GeneratorInvokerService.Generate<BaryonicMatterVoidStructure, BaryonicMatterVoidStructureContext>(baryonicMatterVoidStructureContext, self);

        var baryonicMatterSheetStructureContext = new BaryonicMatterSheetStructureContext(self);
        self.BaryonicMatterSheetStructure = await GeneratorInvokerService.Generate<BaryonicMatterSheetStructure, BaryonicMatterSheetStructureContext>(baryonicMatterSheetStructureContext, self);

        var baryonicMatterFilamentStructureContext = new BaryonicMatterFilamentStructureContext(self);
        self.BaryonicMatterFilamentStructure = await GeneratorInvokerService.Generate<BaryonicMatterFilamentStructure, BaryonicMatterFilamentStructureContext>(baryonicMatterFilamentStructureContext, self);

        var baryonicMatterNodeStructureContext = new BaryonicMatterNodeStructureContext(self);
        self.BaryonicMatterNodeStructure = await GeneratorInvokerService.Generate<BaryonicMatterNodeStructure, BaryonicMatterNodeStructureContext>(baryonicMatterNodeStructureContext, self);



        if (ConfigurationService.GetConfiguration<AstronomicalObjectToggleSettings>().DarkMatterAndDarkEnergyEnabled)
        {
            var darkMatterVoidStructureContext = new DarkMatterVoidStructureContext(self);
            self.DarkMatterVoidStructure = await GeneratorInvokerService.Generate<DarkMatterVoidStructure, DarkMatterVoidStructureContext>(darkMatterVoidStructureContext, self);

            var darkMatterSheetStructureContext = new DarkMatterSheetStructureContext(self);
            self.DarkMatterSheetStructure = await GeneratorInvokerService.Generate<DarkMatterSheetStructure, DarkMatterSheetStructureContext>(darkMatterSheetStructureContext, self);

            var darkMatterFilamentStructureContext = new DarkMatterFilamentStructureContext(self);
            self.DarkMatterFilamentStructure = await GeneratorInvokerService.Generate<DarkMatterFilamentStructure, DarkMatterFilamentStructureContext>(darkMatterFilamentStructureContext, self);

            var darkMatterNodeStructureContext = new DarkMatterNodeStructureContext(self);
            self.DarkMatterNodeStructure = await GeneratorInvokerService.Generate<DarkMatterNodeStructure, DarkMatterNodeStructureContext>(darkMatterNodeStructureContext, self);
        }
    }

    protected override void GenerateInteriorObjects(CosmicWebContext context, CosmicWeb self)
    {
        self.InteriorObjects = new List<IUndefinedAstronomicalObject>();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        self.InteriorRandomizationAlgorithm = null;
    }

    protected override async Task<CosmicWeb> GenerateSelf(CosmicWebContext context, CosmicWeb self)
    {
        return self;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        self.SurfaceNoiseAlgorithm = null;
    }

    protected override void GenerateWarpedSurface(CosmicWebContext context, CosmicWeb self)
    {
        self.WarpedSurface = new List<Vector3>();
    }

    protected override void SetMatterType(CosmicWebContext context, CosmicWeb self)
    {
        self.MatterType = ConfigurationService.GetConfiguration<AstronomicalObjectToggleSettings>().DarkMatterAndDarkEnergyEnabled ? MatterType.Mixed : MatterType.BaryonicMatter;
    }

    internal override void AssignChildren(CosmicWebContext context, CosmicWeb self)
    {
        self.Children.Add(self.IntergalacticMedium);
        self.Children.Add(self.BaryonicMatterFilamentStructure);
        self.Children.Add(self.BaryonicMatterNodeStructure);
        self.Children.Add(self.BaryonicMatterSheetStructure);
        self.Children.Add(self.BaryonicMatterVoidStructure);
        self.Children.Add(self.DarkMatterFilamentStructure);
        self.Children.Add(self.DarkMatterNodeStructure);
        self.Children.Add(self.DarkMatterSheetStructure);
        self.Children.Add(self.DarkMatterVoidStructure);
    }

    public override void GenerateRandomGenerationAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        throw new NotImplementedException();
    }
}