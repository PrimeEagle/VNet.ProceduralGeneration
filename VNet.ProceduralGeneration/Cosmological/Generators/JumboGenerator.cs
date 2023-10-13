using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class JumboGenerator : GeneratorBase<Jumbo, JumboContext>
{
    public JumboGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override Task<Jumbo> GenerateSelf(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void SetMatterType(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void PostProcess(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }
}