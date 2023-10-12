using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MagnetarGenerator : GeneratorBase<Magnetar, MagnetarContext>
{
    public MagnetarGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Magnetar> GenerateSelf(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(MagnetarContext context, Magnetar self)
    {
        throw new NotImplementedException();
    }
}