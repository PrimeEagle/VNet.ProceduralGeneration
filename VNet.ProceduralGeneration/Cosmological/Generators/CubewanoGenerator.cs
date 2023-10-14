using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CubewanoGenerator : GeneratorBase<Cubewano, CubewanoContext>
{
    public CubewanoGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Cubewano> GenerateSelf(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CubewanoContext context, Cubewano self)
    {
        throw new NotImplementedException();
    }
}