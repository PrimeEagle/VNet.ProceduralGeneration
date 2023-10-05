using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class JumboGenerator : GeneratorBase<Jumbo, JumboContext>
{
    protected override void GenerateAge(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateDiameter(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override Task<Jumbo> GenerateSelf(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(JumboContext context, Jumbo self)
    {
        throw new NotImplementedException();
    }

    public JumboGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }
}