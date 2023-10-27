using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public interface IGenerator<T, in TContext> where T : AstronomicalObject
    where TContext : ContextBase
{
    Task<T> Generate(TContext context, AstronomicalObject parent);
}