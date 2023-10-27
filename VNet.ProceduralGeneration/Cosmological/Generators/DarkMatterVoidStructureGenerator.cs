using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterVoidStructureGenerator : VoidStructureGenerator<DarkMatterVoidStructure, DarkMatterVoidStructureContext>
{
    public DarkMatterVoidStructureGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService) : base(eventAggregator, generatorInvokerService, configurationService)
    {
    }

    protected override Task GenerateChildren(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DarkMatterVoidStructure> GenerateSelf(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(DarkMatterVoidStructureContext context, DarkMatterVoidStructure self)
    {
        throw new NotImplementedException();
    }
}