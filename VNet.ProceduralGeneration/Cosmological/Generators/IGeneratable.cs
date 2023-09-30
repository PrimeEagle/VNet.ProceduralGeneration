namespace VNet.ProceduralGeneration.Cosmological;

public interface IGeneratable<T, TContext> where T        : AstronomicalObject 
                                           where TContext : BaseContext
{
    Task<T> Generate(TContext context);
}