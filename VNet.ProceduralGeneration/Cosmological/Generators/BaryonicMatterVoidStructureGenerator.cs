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

    protected override Task GenerateChildren(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {



    }

    protected override void GenerateInteriorObjects(BaryonicMatterVoidStructureContext context, BaryonicMatterVoidStructure self)
    {
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