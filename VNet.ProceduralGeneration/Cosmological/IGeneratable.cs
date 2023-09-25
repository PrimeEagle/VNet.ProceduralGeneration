namespace VNet.ProceduralGeneration.Cosmological;

public interface IGeneratable<T, TContext>
{
    T Generate(TContext context);
}