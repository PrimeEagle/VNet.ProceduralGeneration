using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ProtoplanetaryDiskGenerator : ContainerGeneratorBase<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public ProtoplanetaryDiskGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task<ProtoplanetaryDisk> GenerateSelf(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }
}