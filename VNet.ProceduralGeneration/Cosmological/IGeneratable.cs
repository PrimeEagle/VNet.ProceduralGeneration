namespace VNet.ProceduralGeneration.Cosmological;

public interface IGeneratable<T, TContext> where T        : AstronomicalObject 
                                           where TContext : BaseContext
{
    T Generate(TContext context);
}