﻿using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ProtoplanetaryDiskGenerator : GeneratorBase<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public ProtoplanetaryDiskGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<ProtoplanetaryDisk> GenerateSelf(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }
}