using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Events;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeProtected.Global
#pragma warning disable CA2208
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class GeneratorBase<T, TContext> : IGeneratable<T, TContext>, IDisposable
                                                    where T : AstronomicalObject, new()
                                                    where TContext : ContextBase
{
    private readonly ParallelismLevel _parallelismLevel;
    private readonly SemaphoreSlim _semaphore;
    protected readonly AdvancedGenerationSettings AdvancedSettings;
    protected readonly BasicGenerationSettings BasicSettings;
    protected readonly EventAggregator EventAggregator;
    protected readonly AstronomicalObjectToggleSettings ObjectToggles;
    protected readonly GeneratorSettings Settings;
    protected readonly TheoreticalAstronomicalObjectToggleSettings TheoreticalObjectToggles;
    private bool _disposed;
    protected TContext Context;


    protected bool Enabled;

    protected GeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel)
    {
        Settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
        BasicSettings = Settings.Basic;
        AdvancedSettings = Settings.Advanced;
        ObjectToggles = Settings.ObjectToggles;
        TheoreticalObjectToggles = Settings.TheoreticalObjectToggles;
        _parallelismLevel = parallelismLevel;
        EventAggregator = eventAggregator;
        _semaphore = new SemaphoreSlim(GetDegreesOfParallelism());
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public virtual async Task<T> Generate(TContext context, AstronomicalObject parent)
    {
        T self;
        Context = context;

        if (Enabled)
        {
            EventBuilder.CreateGeneratingEvent(EventAggregator, nameof(T), null);
            self = new T
            {
                Parent = parent,
                Enabled = true
            };
            self = await ExecuteWithConcurrencyControlAsync(() => GenerateSelf(context, self));
        }
        else
        {
            self = new T();
        }

        self.Parent = parent;
        if (!parent.Enabled) self.Universe.NonHierarchyObjects.Add(self);

        await GenerateChildren(context, self);

        if (!Enabled) return self;
        GenerateBaseProperties(context, self);
        self.AssignChildren();
        EventBuilder.CreateGeneratedEvent(EventAggregator, nameof(T), self);

        EventBuilder.CreatePostProcessingEvent(EventAggregator, nameof(T), self);
        PostProcess(context, self);
        EventBuilder.CreatePostProcessedEvent(EventAggregator, nameof(T), self);

        return self;
    }

    protected abstract Task<T> GenerateSelf(TContext context, T self);
    protected abstract Task GenerateChildren(TContext context, T self);
    protected abstract void SetMatterType(TContext context, T self);
    protected abstract void PostProcess(TContext context, T self);

    protected async Task<T> ExecuteWithConcurrencyControlAsync<T>(Func<Task<T>> taskFactory)
    {
        await _semaphore.WaitAsync();
        try
        {
            return await Task.Run(taskFactory);
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private int GetDegreesOfParallelism()
    {
        var parallelismMap = new Dictionary<ParallelismLevel, (int calculated, int configured)>
        {
            [ParallelismLevel.Level0] = (1, 1),
            [ParallelismLevel.Level1] = (Environment.ProcessorCount, AdvancedSettings.Application.MaxDegreesOfParallelismLevel1),
            [ParallelismLevel.Level2] = (Convert.ToInt32(0.75 * Environment.ProcessorCount), AdvancedSettings.Application.MaxDegreesOfParallelismLevel2),
            [ParallelismLevel.Level3] = (Convert.ToInt32(0.5 * Environment.ProcessorCount), AdvancedSettings.Application.MaxDegreesOfParallelismLevel3),
            [ParallelismLevel.Level4] = (Convert.ToInt32(0.25 * Environment.ProcessorCount), AdvancedSettings.Application.MaxDegreesOfParallelismLevel4)
        };

        if (!parallelismMap.TryGetValue(_parallelismLevel, out var values)) throw new ArgumentOutOfRangeException();

        return Math.Min(values.calculated, values.configured);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing) _semaphore?.Dispose();

        _disposed = true;
    }

    public virtual void GenerateBoundingBox(TContext context, T self)
    {
        self.BoundingBox = new BoundingBox<float>(self.Position, 1, self.Orientation);
    }

    public virtual void GenerateDiameter(TContext context, T self)
    {
        if (context.Diameter.HasValue)
            self.Diameter = context.Diameter.Value;
        else if (context is { DiameterCreateRange: not null, RandomizationAlgorithm: not null })
            self.Diameter = context.RandomizationAlgorithm.NextSingle(context.DiameterCreateRange.Value.Item1, context.DiameterCreateRange.Value.Item2);
    }

    public virtual void GeneratePosition(TContext context, T self)
    {
        if (context.Position.HasValue)
            self.Position = context.Position.Value;
        else if (context is { PositionXCreateRange: not null, PositionYCreateRange: not null, PositionZCreateRange: not null, RandomizationAlgorithm: not null })
            self.Position = new Vector3(
                context.RandomizationAlgorithm.NextSingle(context.PositionXCreateRange.Value.Item1, context.PositionXCreateRange.Value.Item2),
                context.RandomizationAlgorithm.NextSingle(context.PositionYCreateRange.Value.Item1, context.PositionYCreateRange.Value.Item2),
                context.RandomizationAlgorithm.NextSingle(context.PositionZCreateRange.Value.Item1, context.PositionZCreateRange.Value.Item2)
            );
    }

    public virtual void GenerateOrientation(TContext context, T self)
    {
        if (context.Orientation.HasValue)
            self.Orientation = context.Orientation.Value;
        else if (context is { OrientationXCreateRange: not null, OrientationYCreateRange: not null, OrientationZCreateRange: not null, RandomizationAlgorithm: not null })
            self.Orientation = new Vector3(
                context.RandomizationAlgorithm.NextSingle(context.OrientationXCreateRange.Value.Item1, context.OrientationXCreateRange.Value.Item2),
                context.RandomizationAlgorithm.NextSingle(context.OrientationYCreateRange.Value.Item1, context.OrientationYCreateRange.Value.Item2),
                context.RandomizationAlgorithm.NextSingle(context.OrientationZCreateRange.Value.Item1, context.OrientationZCreateRange.Value.Item2)
            );
    }

    public virtual void GenerateAge(TContext context, T self)
    {
        if (context.Age.HasValue)
            self.Age = context.Age.Value;
        else if (context is { AgeCreateRange: not null, RandomizationAlgorithm: not null })
            self.Age = context.RandomizationAlgorithm.NextSingle(context.AgeCreateRange.Value.Item1, context.AgeCreateRange.Value.Item2);
    }

    public virtual void GenerateLifespan(TContext context, T self)
    {
        if (context.Lifespan.HasValue)
            self.Lifespan = context.Lifespan.Value;
        else if (context is { LifespanCreateRange: not null, RandomizationAlgorithm: not null })
            self.Lifespan = context.RandomizationAlgorithm.NextSingle(context.LifespanCreateRange.Value.Item1, context.LifespanCreateRange.Value.Item2);
    }

    public virtual void GenerateMass(TContext context, T self)
    {
        if (context.Mass.HasValue)
            self.Mass = context.Mass.Value;
        else if (context is { MassCreateRange: not null, RandomizationAlgorithm: not null })
            self.Mass = context.RandomizationAlgorithm.NextDouble(context.MassCreateRange.Value.Item1, context.MassCreateRange.Value.Item2);
    }

    public virtual void GenerateLuminosity(TContext context, T self)
    {
        if (context.Luminosity.HasValue)
            self.Luminosity = context.Luminosity.Value;
        else if (context is { LuminosityCreateRange: not null, RandomizationAlgorithm: not null })
            self.Luminosity = context.RandomizationAlgorithm.NextSingle(context.LuminosityCreateRange.Value.Item1, context.LuminosityCreateRange.Value.Item2);
    }

    public virtual void GenerateTemperature(TContext context, T self)
    {
        if (context.Temperature.HasValue)
            self.Temperature = context.Temperature.Value;
        else if (context is { TemperatureCreateRange: not null, RandomizationAlgorithm: not null })
            self.Temperature = context.RandomizationAlgorithm.NextSingle(context.TemperatureCreateRange.Value.Item1, context.TemperatureCreateRange.Value.Item2);
    }

    protected virtual void GenerateBaseProperties(TContext context, T self)
    {
        SetMatterType(context, self);
        GenerateDiameter(context, self);
        GeneratePosition(context, self);
        GenerateOrientation(context, self);
        GenerateAge(context, self);
        GenerateLifespan(context, self);
        GenerateMass(context, self);
        GenerateLuminosity(context, self);
        GenerateTemperature(context, self);
        GenerateBoundingBox(context, self);
    }
}