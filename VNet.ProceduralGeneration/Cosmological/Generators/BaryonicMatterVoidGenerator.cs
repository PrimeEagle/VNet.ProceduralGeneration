using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidGenerator : VoidGeneratorBase<BaryonicMatterVoid, BaryonicMatterVoidContext>
{
    public BaryonicMatterVoidGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override async Task<BaryonicMatterVoid> GenerateSelf(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        return self;
    }

    protected override async Task GenerateChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        var numGalaxyGroups = self.RandomGenerationAlgorithm.NextInclusive(0, 10);
        for (var i = 0; i < numGalaxyGroups; i++)
        {
            var galaxyGroupContext = new GalaxyGroupContext()
            {
            };
            var galaxyGroupGenerator = new GalaxyGroupGenerator(EventAggregator, ParallelismLevel.Level1);
            var newGalaxyGroup = await galaxyGroupGenerator.Generate(galaxyGroupContext, self.Parent);

            self.GalaxyGroups.Add(newGalaxyGroup);
        }

        var numGalaxies = self.RandomGenerationAlgorithm.NextInclusive(0, 10);
        for (var i = 0; i < numGalaxies; i++)
        {
            var galaxyContext = new GalaxyContext()
            {
            };
            var galaxyGenerator = new GalaxyGenerator(EventAggregator, ParallelismLevel.Level1);
            var newGalaxy = await galaxyGenerator.Generate(galaxyContext, self.Parent);

            self.Galaxies.Add(newGalaxy);
        }

        var numVoidGalaxies = self.RandomGenerationAlgorithm.NextInclusive(0, 10);
        for (var i = 0; i < numVoidGalaxies; i++)
        {
            var voidGalaxyContext = new VoidGalaxyContext()
            {
            };
            var voidGalaxyGenerator = new VoidGalaxyGenerator(EventAggregator, ParallelismLevel.Level1);
            var newVoidGalaxy = await voidGalaxyGenerator.Generate(voidGalaxyContext, self.Parent);

            self.VoidGalaxies.Add(newVoidGalaxy);
        }
    }

    protected override void SetMatterType(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.MatterType = MatterType.BaryonicMatter;
    }

    public override void GenerateRandomGenerationAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.InteriorRandomizationAlgorithm = context.InteriorObjectRandomizationAlgorithm;
    }

    protected override void GenerateSurfaceNoiseAlgorithm(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.SurfaceNoiseAlgorithm = context.SurfaceWarpingNoiseAlgorithm;
    }

    internal override void AssignChildren(BaryonicMatterVoidContext context, BaryonicMatterVoid self)
    {
        self.Children.AddRange(self.GalaxyGroups);
        self.Children.AddRange(self.Galaxies);
        self.Children.AddRange(self.VoidGalaxies);
    }
}