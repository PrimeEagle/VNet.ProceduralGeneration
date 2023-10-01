﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicStringGenerator : BaseGenerator<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicString> GenerateSelf(CosmicStringContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicString self, CosmicStringContext context)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicString self, CosmicStringContext context)
    {
        throw new NotImplementedException();
    }
}