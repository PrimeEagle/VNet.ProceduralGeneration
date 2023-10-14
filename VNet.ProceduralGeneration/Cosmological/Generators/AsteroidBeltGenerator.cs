using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class AsteroidBeltGenerator : GeneratorBase<AsteroidBelt, AsteroidBeltContext>
{
    public AsteroidBeltGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<AsteroidBelt> GenerateSelf(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(AsteroidBeltContext context, AsteroidBelt self)
    {
        throw new NotImplementedException();
    }
}