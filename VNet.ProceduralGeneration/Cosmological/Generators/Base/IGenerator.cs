using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public interface IGenerator<T, in TContext> where T : AstronomicalObject
    where TContext : ContextBase
{
    public Task<T> Generate(TContext context, AstronomicalObject parent);
    public void GenerateDiameter(TContext context, T self);
    public void GeneratePosition(TContext context, T self);
    public void GenerateOrientation(TContext context, T self);
    public void GenerateAge(TContext context, T self);
    public void GenerateLifespan(TContext context, T self);
    public void GenerateMass(TContext context, T self);
    public void GenerateLuminosity(TContext context, T self);
    public void GenerateTemperature(TContext context, T self);
}