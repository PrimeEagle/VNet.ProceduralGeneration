using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CosmicTopologicalDefectGenerator : GeneratorBase<CosmicTopologicalDefect, CosmicTopologicalDefectContext>
{
    public CosmicTopologicalDefectGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<CosmicTopologicalDefect> GenerateSelf(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(CosmicTopologicalDefectContext context, CosmicTopologicalDefect self)
    {
        throw new NotImplementedException();
    }
}