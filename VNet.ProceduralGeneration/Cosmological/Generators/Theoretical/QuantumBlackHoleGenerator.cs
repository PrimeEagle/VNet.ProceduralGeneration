using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class QuantumBlackHoleGenerator : GeneratorBase<QuantumBlackHole, QuantumBlackHoleContext>
{
    public QuantumBlackHoleGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<QuantumBlackHole> GenerateSelf(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(QuantumBlackHoleContext context, QuantumBlackHole self)
    {
        throw new NotImplementedException();
    }
}