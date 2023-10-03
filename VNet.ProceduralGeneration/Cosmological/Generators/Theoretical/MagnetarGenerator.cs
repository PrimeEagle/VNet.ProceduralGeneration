﻿using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MagnetarGenerator : GeneratorBase<Magnetar, MagnetarContext>
{
    public MagnetarGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Magnetar> GenerateSelf(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }
}