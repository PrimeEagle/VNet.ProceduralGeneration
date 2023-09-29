using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class MagnetarGenerator : BaseGenerator<Magnetar, MagnetarContext>
{
    public MagnetarGenerator(GeneratorConfig config) : base(config)
    {
    }

    public override Magnetar Generate(MagnetarContext context)
    {
        throw new NotImplementedException();
    }
}