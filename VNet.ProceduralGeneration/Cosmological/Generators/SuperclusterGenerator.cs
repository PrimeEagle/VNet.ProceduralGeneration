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

    protected override float GenerateAge(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(SuperclusterContext context, Supercluster self)
    {
        throw new NotImplementedException();
    }
}