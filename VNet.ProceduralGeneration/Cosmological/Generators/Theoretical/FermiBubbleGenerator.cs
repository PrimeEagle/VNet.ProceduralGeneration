using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class FermiBubbleGenerator : GeneratorBase<FermiBubble, FermiBubbleContext>
{
    public FermiBubbleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task<FermiBubble> GenerateSelf(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(FermiBubbleContext context, FermiBubble self)
    {
        throw new NotImplementedException();
    }
}