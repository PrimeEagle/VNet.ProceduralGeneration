﻿using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class StarGenerator : BaseGenerator<Star, StarContext>
{
    public override Star Generate(StarContext context)
    {
        var star = new Star
        {

        };

        return star;
    }

    public StarGenerator()
    {
    }
}