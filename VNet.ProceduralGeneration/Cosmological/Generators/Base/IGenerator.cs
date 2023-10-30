using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public interface IGenerator<T, in TContext> where T : AstronomicalObject
    where TContext : ContextBase
{
    public T Generate(TContext context, AstronomicalObject parent);
    public void GenerateDiameter(TContext context, T self);
    public void GeneratePosition(TContext context, T self);
    public void GenerateOrientation(TContext context, T self);
    public void GenerateAge(TContext context, T self);
    public void GenerateLifespan(TContext context, T self);
    public void GenerateMass(TContext context, T self);
    public void GenerateLuminosity(TContext context, T self);
    public void GenerateTemperature(TContext context, T self);
    public Task<T> GenerateAsync(TContext context, AstronomicalObject parent);
    public Task GenerateDiameterAsync(TContext context, T self);
    public Task GeneratePositionAsync(TContext context, T self);
    public Task GenerateOrientationAsync(TContext context, T self);
    public Task GenerateAgeAsync(TContext context, T self);
    public Task GenerateLifespanAsync(TContext context, T self);
    public Task GenerateMassAsync(TContext context, T self);
    public Task GenerateLuminosityAsync(TContext context, T self);
    public Task GenerateTemperatureAsync(TContext context, T self);
}