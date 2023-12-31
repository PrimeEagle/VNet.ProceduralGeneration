﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class CosmicDustLaneContext : ContextBase
{
    public CosmicDustLaneContext()
    {
    }

    public CosmicDustLaneContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }
}