namespace VNet.ProceduralGeneration.Cosmological;

public class ProtoplanetaryDiskGenerator : BaseGenerator<ProtoplanetaryDisk, ProtoplanetaryDiskContext>
{
    public override ProtoplanetaryDisk Generate(ProtoplanetaryDiskContext context)
    {
        var disk = new ProtoplanetaryDisk
        {

        };

        return disk;
    }

    public ProtoplanetaryDiskGenerator(GeneratorConfig config) : base(config)
    {
    }
}