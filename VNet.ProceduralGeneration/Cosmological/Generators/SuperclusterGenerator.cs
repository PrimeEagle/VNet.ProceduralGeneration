using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class SuperclusterGenerator : GeneratorBase<Supercluster, SuperclusterContext>
{
    public SuperclusterGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Supercluster> GenerateSelf(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAge(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override double CalculateMass(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateTemperature(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateLifespan(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 CalculatePosition(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }
}