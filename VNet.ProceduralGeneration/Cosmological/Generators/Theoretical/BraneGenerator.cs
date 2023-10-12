using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class BraneGenerator : GeneratorBase<Brane, BraneContext>
{
    public BraneGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Brane> GenerateSelf(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(BraneContext context, Brane self)
    {
        throw new NotImplementedException();
    }
}