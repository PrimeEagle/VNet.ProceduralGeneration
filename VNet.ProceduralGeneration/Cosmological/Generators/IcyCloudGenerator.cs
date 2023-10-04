using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class IcyCloudGenerator : GeneratorBase<IcyCloud, IcyCloudContext>
{
    public IcyCloudGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<IcyCloud> GenerateSelf(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateAge(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateSize(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override double GenerateMass(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override float CalculateAbsoluteMagnitude(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateTemperature(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override float GenerateLifespan(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }

    protected override Vector3 GeneratePosition(IcyCloudContext context, IcyCloud self)
    {
        throw new NotImplementedException();
    }
}