using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;

namespace VNet.ProceduralGeneration.Cosmological.Generators;

public interface IGeneratable<T, in TContext> where T        : AstronomicalObject 
                                              where TContext : ContextBase
{
    Task<T> Generate(TContext context, AstronomicalObject parent);
}