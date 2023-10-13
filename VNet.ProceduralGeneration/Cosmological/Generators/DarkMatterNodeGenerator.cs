﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : NodeGeneratorBase<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<DarkMatterNode> GenerateSelf(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }
}