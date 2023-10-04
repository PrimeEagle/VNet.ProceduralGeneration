﻿using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class KugelblitzGenerator : GeneratorBase<Kugelblitz, KugelblitzContext>
{
    public KugelblitzGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Kugelblitz> GenerateSelf(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(KugelblitzContext context, Kugelblitz self)
    {
        throw new NotImplementedException();
    }
}