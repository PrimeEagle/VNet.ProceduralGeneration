using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NovaGenerator : GeneratorBase<Nova, NovaContext>
{
    public NovaGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Nova> GenerateSelf(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(NovaContext context, Nova self)
    {
        throw new NotImplementedException();
    }
}