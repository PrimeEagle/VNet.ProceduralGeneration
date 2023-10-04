using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class DarkMatterNodeGenerator : GeneratorBase<DarkMatterNode, DarkMatterNodeContext>
{
    public DarkMatterNodeGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level1)
    {
        enabled = ObjectToggles.DarkMatterNodesEnabled;
    }

    protected override Task<DarkMatterNode> GenerateSelf(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(DarkMatterNodeContext context, DarkMatterNode self)
    {
        throw new NotImplementedException();
    }
}