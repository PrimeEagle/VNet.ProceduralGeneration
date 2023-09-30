using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological;

public class MagnetarGenerator : BaseGenerator<Magnetar, MagnetarContext>
{
    public MagnetarGenerator()
    {
    }

    public async override Task<Magnetar> Generate(MagnetarContext context)
    {
        var result = new Magnetar();
        return result;
    }
}