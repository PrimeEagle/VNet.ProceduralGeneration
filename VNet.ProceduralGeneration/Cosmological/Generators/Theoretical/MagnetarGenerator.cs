using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MagnetarGenerator : BaseGenerator<Magnetar, MagnetarContext>
{
    public MagnetarGenerator() : base(ParallelismLevel.Level4)
    {
    }

    protected override Task<Magnetar> GenerateSelf(MagnetarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Magnetar self, MagnetarContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Magnetar self, MagnetarContext context)
    {
        throw new NotImplementedException();
    }
}