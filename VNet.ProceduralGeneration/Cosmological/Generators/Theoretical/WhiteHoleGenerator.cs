using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class WhiteHoleGenerator : GeneratorBase<WhiteHole, WhiteHoleContext>
{
    public WhiteHoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<WhiteHole> GenerateSelf(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(WhiteHoleContext context, WhiteHole self)
    {
        throw new NotImplementedException();
    }
}