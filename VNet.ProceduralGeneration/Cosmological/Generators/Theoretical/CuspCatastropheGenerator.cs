using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Contexts.Theoretical;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Theoretical;

public class CuspCatastropheGenerator : GeneratorBase<CuspCatastrophe, CuspCatastropheContext>
{
    public CuspCatastropheGenerator(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected override void GenerateDiameter(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void GeneratePosition(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateAge(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLifespan(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateMass(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateLuminosity(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override void GenerateTemperature(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override Task<CuspCatastrophe> GenerateSelf(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(CuspCatastropheContext context, CuspCatastrophe self)
    {
        throw new NotImplementedException();
    }
}