using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class ProtoplanetaryDiskGenerator : BaseGenerator<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public async override Task<ProtoplanetaryDisk> Generate(ProtoplanetaryDiskContext context)
    {
        var disk = new ProtoplanetaryDisk
        {

        };

        return disk;
    }

    public ProtoplanetaryDiskGenerator()
    {
    }
}