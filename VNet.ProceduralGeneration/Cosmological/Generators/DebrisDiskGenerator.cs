using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DebrisDiskGenerator : ContainerGeneratorBase<DebrisDisk, DebrisDiskContext>
{
    public DebrisDiskGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<DebrisDisk> GenerateSelf(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }
}