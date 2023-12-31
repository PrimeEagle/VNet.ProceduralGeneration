﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class BraneContext : ContextBase
{
    public BraneContext()
    {
    }

    public BraneContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }
}