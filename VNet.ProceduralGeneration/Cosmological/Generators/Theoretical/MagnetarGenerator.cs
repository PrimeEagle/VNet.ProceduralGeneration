﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MagnetarGenerator : BaseGenerator<Magnetar, MagnetarContext>
{
    public MagnetarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    public override async Task<Magnetar> Generate(MagnetarContext context)
    {
        var result = new Magnetar();
        return result;
    }
}