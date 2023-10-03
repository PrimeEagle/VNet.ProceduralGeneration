using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicStringGenerator : GeneratorBase<CosmicString, CosmicStringContext>
{
    public CosmicStringGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicString> GenerateSelf(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(CosmicStringContext context, CosmicString self)
    {
        throw new NotImplementedException();
    }
}