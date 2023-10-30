using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Services;

public interface IGeneratorInvokerService
{
    public T Generate<T, TContext>(TContext context, AstronomicalObject parent)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateDiameter<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GeneratePosition<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateOrientation<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateAge<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateLifespan<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateMass<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateLuminosity<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public void GenerateTemperature<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task<T> GenerateAsync<T, TContext>(TContext context, AstronomicalObject parent)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateDiameterAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GeneratePositionAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateOrientationAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateAgeAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateLifespanAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateMassAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateLuminosityAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
    public Task GenerateTemperatureAsync<T, TContext>(TContext context, T self)
        where T : AstronomicalObject
        where TContext : ContextBase;
}