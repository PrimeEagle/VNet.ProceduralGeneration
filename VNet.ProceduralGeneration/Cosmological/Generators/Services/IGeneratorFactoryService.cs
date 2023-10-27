using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Generators.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Services;

public interface IGeneratorFactoryService
{
    IGenerator<T, TContext> Create<T, TContext>()
        where T : AstronomicalObject
        where TContext : ContextBase;
}