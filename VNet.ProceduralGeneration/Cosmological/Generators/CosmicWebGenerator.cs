using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;
using VNet.System.Events;


// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedParameter.Local
// ReSharper disable PossibleLossOfFraction


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CosmicWebGenerator : GroupGeneratorBase<CosmicWeb, CosmicWebContext>
{
    public CosmicWebGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level0)
    {
        Enabled = ObjectToggles.CosmicWebEnabled;
    }

    protected override async Task<CosmicWeb> GenerateSelf(CosmicWebContext context, CosmicWeb self)
    {
        return self;
    }

    protected override async Task GenerateChildren(CosmicWebContext context, CosmicWeb self)
    {
        var intergalacticMediumContext = new IntergalacticMediumContext();
        var intergalacticMediumGenerator = new IntergalacticMediumGenerator(EventAggregator, ParallelismLevel.Level1);
        await intergalacticMediumGenerator.Generate(intergalacticMediumContext, self);



        var baryonicMatterVoidStructureContext = new BaryonicMatterVoidStructureContext();
        var baryonicMatterVoidGenerator = new BaryonicMatterVoidStructureGenerator(EventAggregator, ParallelismLevel.Level1);
        await baryonicMatterVoidGenerator.Generate(baryonicMatterVoidStructureContext, self);

        var baryonicMatterSheetStructureContext = new BaryonicMatterSheetStructureContext();
        var baryonicMatterSheetGenerator = new BaryonicMatterSheetStructureGenerator(EventAggregator, ParallelismLevel.Level1);
        await baryonicMatterSheetGenerator.Generate(baryonicMatterSheetStructureContext, self);

        var baryonicMatterFilamentStructureContext = new BaryonicMatterFilamentStructureContext();
        var baryonicMatterFilamentGenerator = new BaryonicMatterFilamentStructureGenerator(EventAggregator, ParallelismLevel.Level1);
        await baryonicMatterFilamentGenerator.Generate(baryonicMatterFilamentStructureContext, self);

        var baryonicMatterNodeStructureContext = new BaryonicMatterNodeStructureContext();
        var baryonicMatterNodeGenerator = new BaryonicMatterNodeStructureGenerator(EventAggregator, ParallelismLevel.Level1);
        await baryonicMatterNodeGenerator.Generate(baryonicMatterNodeStructureContext, self);



        if (TheoreticalObjectToggles.DarkMatterEnabled)
        {
            var darkMatterVoidStructureContext = new DarkMatterVoidStructureContext();
            var darkMatterVoidGenerator = new DarkMatterVoidStructureGenerator(EventAggregator, ParallelismLevel.Level1);
            await darkMatterVoidGenerator.Generate(darkMatterVoidStructureContext, self);

            var darkMatterSheetStructureContext = new DarkMatterSheetStructureContext();
            var darkMatterSheetGenerator = new DarkMatterSheetStructureGenerator(EventAggregator, ParallelismLevel.Level1);
            await darkMatterSheetGenerator.Generate(darkMatterSheetStructureContext, self);

            var darkMatterFilamentStructureContext = new DarkMatterFilamentStructureContext();
            var darkMatterFilamentGenerator = new DarkMatterFilamentStructureGenerator(EventAggregator, ParallelismLevel.Level1);
            await darkMatterFilamentGenerator.Generate(darkMatterFilamentStructureContext, self);

            var darkMatterNodeStructureContext = new DarkMatterNodeStructureContext();
            var darkMatterNodeGenerator = new DarkMatterNodeStructureGenerator(EventAggregator, ParallelismLevel.Level1);
            await darkMatterNodeGenerator.Generate(darkMatterNodeStructureContext, self);
        }
    }

    protected override void GenerateWarpedSurface(CosmicWebContext context, CosmicWeb self)
    {
    }

    protected override void GenerateInteriorObjects(CosmicWebContext context, CosmicWeb self)
    {
    }

    protected override void GenerateInteriorRandomizationAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        self.InteriorRandomizationAlgorithm = null;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(CosmicWebContext context, CosmicWeb self)
    {
        self.SurfaceNoiseAlgorithm = null;
    }

    protected override void SetMatterType(CosmicWebContext context, CosmicWeb self)
    {
        self.MatterType = TheoreticalObjectToggles.DarkMatterEnabled ? MatterType.Mixed : MatterType.BaryonicMatter;
    }

    internal override void AssignChildren(CosmicWebContext context, CosmicWeb self)
    {
        self.Children.Add(self.IntergalacticMedium);
        self.Children.AddRange(self.BaryonicMatterNodes);
        self.Children.AddRange(self.BaryonicMatterFilaments);
        self.Children.AddRange(self.BaryonicMatterSheets);
        self.Children.AddRange(self.BaryonicMatterVoids);
        self.Children.AddRange(self.DarkMatterNodes);
        self.Children.AddRange(self.DarkMatterFilaments);
        self.Children.AddRange(self.DarkMatterSheets);
        self.Children.AddRange(self.DarkMatterVoids);
    }
}