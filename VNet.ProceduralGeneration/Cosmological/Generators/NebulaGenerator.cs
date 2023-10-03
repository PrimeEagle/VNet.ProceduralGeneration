using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public class NebulaGenerator : GeneratorBase<Nebula, NebulaContext>
{
    public NebulaGenerator(EventAggregator eventAggregator) : base(eventAggregator, ParallelismLevel.Level4)
    {
    }

    protected override Task<Nebula> GenerateSelf(NebulaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task GenerateChildren(Nebula self, NebulaContext context)
    {
        throw new NotImplementedException();
    }

    protected override Task PostProcess(Nebula self, NebulaContext context)
    {
        throw new NotImplementedException();
    }
}