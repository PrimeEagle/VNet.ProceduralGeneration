﻿using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class LargeQuasarGroupGenerator : GroupGeneratorBase<LargeQuasarGroup, LargeQuasarGroupContext>
{
    public LargeQuasarGroupGenerator(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService, IConfigurationService configurationService, ILogger<LargeQuasarGroupGenerator> loggerService, IAstronomicalCalculationService calculationService) : base(eventAggregator, generatorInvokerService, configurationService, loggerService, calculationService)
    {
    }

    protected override Task GenerateChildren(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override Task<LargeQuasarGroup> GenerateSelf(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(LargeQuasarGroupContext context, LargeQuasarGroup self)
    {
        throw new NotImplementedException();
    }
}