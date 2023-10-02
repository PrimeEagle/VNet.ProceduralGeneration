using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ProtoplanetaryDiskGenerator : BaseGenerator<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public ProtoplanetaryDiskGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<ProtoplanetaryDisk> GenerateSelf(ProtoplanetaryDiskContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(ProtoplanetaryDisk self, ProtoplanetaryDiskContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(ProtoplanetaryDisk self, ProtoplanetaryDiskContext context)
    {
        throw new NotImplementedException();
    }
}