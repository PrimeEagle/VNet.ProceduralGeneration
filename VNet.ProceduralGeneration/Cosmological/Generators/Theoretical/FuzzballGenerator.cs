﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FuzzballGenerator : GeneratorBase<Fuzzball, FuzzballContext>
{
    public FuzzballGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Fuzzball> GenerateSelf(FuzzballContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Fuzzball self, FuzzballContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Fuzzball self, FuzzballContext context)
    {
        throw new NotImplementedException();
    }
}