using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Services;

public interface IGeneratorInvokerService
{
    public Task<T> Generate<T, TContext>(TContext context, AstronomicalObject parent)
        where T : AstronomicalObject
        where TContext : ContextBase;
}