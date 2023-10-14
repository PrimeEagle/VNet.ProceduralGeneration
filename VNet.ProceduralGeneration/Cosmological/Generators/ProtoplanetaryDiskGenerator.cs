using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ProtoplanetaryDiskGenerator : GroupGeneratorBase<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public ProtoplanetaryDiskGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
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

    protected override void SetMatterType(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateWarpedSurface(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorObjects(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateInteriorRandomizationAlgorithm(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateSurfaceNoiseAlgorithm(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(ProtoplanetaryDiskContext context, ProtoplanetaryDisk self)
    {
        throw new NotImplementedException();
    }
}