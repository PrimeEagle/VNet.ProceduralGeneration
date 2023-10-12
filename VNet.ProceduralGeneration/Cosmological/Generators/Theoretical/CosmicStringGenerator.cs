using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicStringGenerator : GeneratorBase<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateBoundingBox(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateOrientation(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CosmicString> GenerateSelf(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }
}