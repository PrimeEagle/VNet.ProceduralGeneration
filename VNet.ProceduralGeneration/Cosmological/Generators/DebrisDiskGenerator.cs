using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DebrisDiskGenerator : ContainerGeneratorBase<DebrisDisk, DebrisDiskContext>
{
    public DebrisDiskGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task<DebrisDisk> GenerateSelf(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(DebrisDiskContext context, DebrisDisk self)
    {
        throw new NotImplementedException();
    }
}