﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SupernovaGenerator : GeneratorBase<Supernova, SupernovaContext>
{
    public SupernovaGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Supernova> GenerateSelf(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(SupernovaContext context, Supernova self)
    {
        throw new NotImplementedException();
    }
}