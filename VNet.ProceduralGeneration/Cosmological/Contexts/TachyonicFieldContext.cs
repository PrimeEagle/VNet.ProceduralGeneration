﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Contexts;

public class TachyonicFieldContext : ContextBase
{
    public TachyonicFieldContext()
    {
    }

    public TachyonicFieldContext(CosmicWeb cosmicWeb)
    {
        LoadBaseProperties(cosmicWeb);
    }
}