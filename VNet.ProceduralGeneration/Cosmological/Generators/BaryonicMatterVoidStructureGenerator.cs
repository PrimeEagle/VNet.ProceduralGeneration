using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class BaryonicMatterVoidStructureGenerator : VoidStructureGenerator<BaryonicMatterVoidStructure, BaryonicMatterVoidStructureContext>
{
    public BaryonicMatterVoidStructureGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
        Enabled = ObjectToggles.BaryonicMatterVoidStructureEnabled;
    }   

    protected override async Task GenerateChildren(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
        var baryonicMatterVoidContext = new BaryonicMatterVoidContext
        {
            DiameterCreateRange = (Settings.Advanced.CosmicWeb.Randomized.MinimumBaryonicMatterVoidDiameter, Settings.Advanced.CosmicWeb.Randomized.MaximumBaryonicMatterVoidDiameter),
            RandomizationAlgorithm = Settings.Advanced.CosmicWeb.Randomized.BaryonicMatterVoidRandomizationAlgorithm
        };
        var baryonicMatterVoidGenerator = new BaryonicMatterVoidGenerator(EventAggregator, ParallelismLevel.Level1);

        var volumeSize = Settings.Basic.DimensionX * Settings.Basic.DimensionY * Settings.Basic.DimensionZ;
        var targetTotalVoidVolume = volumeSize * Settings.Advanced.CosmicWeb.Randomized.PercentageOfVolumeCoveredByBaryonicMatterVoids / 100;
        var totalVoidVolume = 0d;

        while (totalVoidVolume < targetTotalVoidVolume)
        {
            var newBaryonicMatterVoid = await baryonicMatterVoidGenerator.Generate(baryonicMatterVoidContext, self.Parent);
            baryonicMatterVoidContext.PositionXCreateRange = (0, Settings.Basic.DimensionX - newBaryonicMatterVoid.Diameter);
            baryonicMatterVoidContext.PositionYCreateRange = (0, Settings.Basic.DimensionY - newBaryonicMatterVoid.Diameter);
            baryonicMatterVoidContext.PositionZCreateRange = (0, Settings.Basic.DimensionZ - newBaryonicMatterVoid.Diameter);
            baryonicMatterVoidGenerator.GeneratePosition(baryonicMatterVoidContext, newBaryonicMatterVoid);

            var acceptableOverlap = false;
            while (!acceptableOverlap)
            {
                var overlapAmount = CalculateOverlapAmount(newBaryonicMatterVoid, self.BaryonicMatterVoids);
                if (overlapAmount < Settings.Advanced.CosmicWeb.Randomized.MinimumBaryonicMatterVoidOverlap || 
                    overlapAmount > Settings.Advanced.CosmicWeb.Randomized.MaximumBaryonicMatterVoidOverlap ||
                    self.BaryonicMatterVoids.Count(x => 
                        CalculateOverlapAmount(newBaryonicMatterVoid, new List<BaryonicMatterVoid> {x}) > 0) / (float) self.BaryonicMatterVoids.Count > Settings.Advanced.CosmicWeb.Randomized.PercentageOfOverlappingBaryonicMatterVoids)
                {
                    baryonicMatterVoidContext.PositionXCreateRange = (0, Settings.Basic.DimensionX - newBaryonicMatterVoid.Diameter);
                    baryonicMatterVoidContext.PositionYCreateRange = (0, Settings.Basic.DimensionY - newBaryonicMatterVoid.Diameter);
                    baryonicMatterVoidContext.PositionZCreateRange = (0, Settings.Basic.DimensionZ - newBaryonicMatterVoid.Diameter);
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

    protected async override Task<BaryonicMatterVoidStructure> GenerateSelf(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
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
}