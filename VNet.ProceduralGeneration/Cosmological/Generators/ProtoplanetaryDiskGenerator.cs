using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class ProtoplanetaryDiskGenerator : BaseGenerator<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public override async Task<ProtoplanetaryDisk> Generate(ProtoplanetaryDiskContext context)
    {
        var disk = new ProtoplanetaryDisk
        {

        };

        return disk;
    }

    public ProtoplanetaryDiskGenerator() : base(ParallelismLevel.Level4)
    {
    }
}