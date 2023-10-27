using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class CuspCatastropheGenerator : GeneratorBase<CuspCatastrophe, CuspCatastropheContext>
{
    public CuspCatastropheGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<CuspCatastrophe> GenerateSelf(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    public override void GenerateRandomGenerationAlgorithm(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    internal override void AssignChildren(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }
}