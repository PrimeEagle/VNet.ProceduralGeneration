﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class BraneGenerator : BaseGenerator<Brane, BraneContext>
{
    public BraneGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<Brane> Generate(BraneContext context)
    {
        var result = new Brane();

        return result;
    }
}