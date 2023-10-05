using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class MonopoleGenerator : GeneratorBase<Monopole, MonopoleContext>
{
    public MonopoleGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Monopole> GenerateSelf(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(MonopoleContext context, Monopole self)
    {
        throw new NotImplementedException();
    }
}