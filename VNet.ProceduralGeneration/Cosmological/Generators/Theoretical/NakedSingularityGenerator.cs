using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class NakedSingularityGenerator : GeneratorBase<NakedSingularity, NakedSingularityContext>
{
    public NakedSingularityGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<NakedSingularity> GenerateSelf(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(NakedSingularityContext context, NakedSingularity self)
    {
        throw new NotImplementedException();
    }
}