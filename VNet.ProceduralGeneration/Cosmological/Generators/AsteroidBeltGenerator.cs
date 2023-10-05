﻿using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : GeneratorBase<AsteroidBelt, AsteroidBeltContext>
{
    public AsteroidBeltGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task<AsteroidBelt> GenerateSelf(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }
}