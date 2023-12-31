﻿using Microsoft.Extensions.Logging;
using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.ProceduralGeneration.Cosmological.Events;
using VNet.ProceduralGeneration.Cosmological.Generators.Services;
using VNet.Scientific.NumericalVolumes;
using VNet.System.Events;

// ReSharper disable ConvertToConstant.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeProtected.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;


public abstract class GeneratorBase<T, TContext> : IGenerator<T, TContext>, IDisposable
                                                    where T : AstronomicalObject, new()
                                                    where TContext : ContextBase
{
    private readonly SemaphoreSlim _semaphore;
    private bool _disposed;

    protected readonly AstronomicalObjectToggleSettings ObjectToggles;
    protected readonly ParallelismLevel ParallelismLevel = ParallelismLevel.Level0;
    protected TContext Context;
    protected bool Enabled;

    protected IEventAggregator EventAggregator { get; }
    protected IGeneratorInvokerService GeneratorInvokerService { get; }
    protected IConfigurationService ConfigurationService { get; }
    protected ILogger<GeneratorBase<T, TContext>> Logger { get; }
    protected IAstronomicalCalculationService CalculationService { get; }




    protected GeneratorBase(IEventAggregator eventAggregator, IGeneratorInvokerService generatorInvokerService,
                            IConfigurationService configurationService, ILogger<GeneratorBase<T, TContext>> loggerService,
                            IAstronomicalCalculationService calculationService)
    {
        EventAggregator = eventAggregator;
        GeneratorInvokerService = generatorInvokerService;
        ConfigurationService = configurationService;
        Logger = loggerService;
        CalculationService = calculationService;
        ObjectToggles = ConfigurationService.GetConfiguration<AstronomicalObjectToggleSettings>();
        _semaphore = new SemaphoreSlim(GetDegreesOfParallelism());
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected abstract Task<T> GenerateSelf(TContext context, T self);
    protected abstract Task GenerateChildren(TContext context, T self);
    protected abstract void SetMatterType(TContext context, T self);
    protected abstract void PostProcess(TContext context, T self);
    public abstract void GenerateRandomGenerationAlgorithm(TContext context, T self);


    protected async Task<TResult> ExecuteWithConcurrencyControlAsync<TResult>(Func<Task<TResult>> taskFactory)
    {
        await _semaphore.WaitAsync();
        try
        {
            return await Task.Run(taskFactory).ConfigureAwait(false);
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private int GetDegreesOfParallelism()
    {
        var applicationSettings = ConfigurationService.GetConfiguration<ApplicationSettings>();
        var parallelismMap = new Dictionary<ParallelismLevel, (int calculated, int configured)>
        {
            [ParallelismLevel.Level0] = (1, 1),
            [ParallelismLevel.Level1] = (Environment.ProcessorCount, applicationSettings.MaxDegreesOfParallelismLevel1),
            [ParallelismLevel.Level2] = (Convert.ToInt32(0.75 * Environment.ProcessorCount), applicationSettings.MaxDegreesOfParallelismLevel2),
            [ParallelismLevel.Level3] = (Convert.ToInt32(0.5 * Environment.ProcessorCount), applicationSettings.MaxDegreesOfParallelismLevel3),
            [ParallelismLevel.Level4] = (Convert.ToInt32(0.25 * Environment.ProcessorCount), applicationSettings.MaxDegreesOfParallelismLevel4)
        };

        if (!parallelismMap.TryGetValue(ParallelismLevel, out var values)) throw new ArgumentOutOfRangeException();

        return Math.Min(values.calculated, values.configured);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed) return;

        if (disposing) _semaphore?.Dispose();

        _disposed = true;
    }

    internal abstract void AssignChildren(TContext context, T self);
    public virtual void GenerateBoundingBox(TContext context, T self)
    {
        self.BoundingBox = new BoundingBox<float>(self.Position, 1, self.Orientation);
    }

    public virtual T Generate(TContext context, AstronomicalObject? parent)
    {
        return GenerateAsync(context, parent).GetAwaiter().GetResult();
    }

    public virtual void GenerateDiameter(TContext context, T self)
    {
        GenerateDiameterAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GeneratePosition(TContext context, T self)
    {
        GeneratePositionAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GenerateOrientation(TContext context, T self)
    {
        GenerateOrientationAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GenerateAge(TContext context, T self)
    {
        GenerateAgeAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GenerateLifespan(TContext context, T self)
    {
        GenerateLifespanAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GenerateMass(TContext context, T self)
    {
        GenerateMassAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GenerateLuminosity(TContext context, T self)
    {
        GenerateLuminosityAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual void GenerateTemperature(TContext context, T self)
    {
        GenerateTemperatureAsync(context, self).GetAwaiter().GetResult();
    }

    public virtual async Task<T> GenerateAsync(TContext context, AstronomicalObject? parent)
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
        if (parent is not null && !parent.Enabled) self.Universe.NonHierarchyObjects.Add(self);

        await GenerateChildren(context, self).ConfigureAwait(false);

        if (!Enabled) return self;
        GenerateBaseProperties(context, self);
        AssignChildren(context, self);
        EventBuilder.CreateGeneratedEvent(EventAggregator, nameof(T), self);

        EventBuilder.CreatePostProcessingEvent(EventAggregator, nameof(T), self);
        PostProcess(context, self);
        EventBuilder.CreatePostProcessedEvent(EventAggregator, nameof(T), self);

        return self;
    }

    public virtual Task GenerateDiameterAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Diameter.HasValue)
                self.Diameter = context.Diameter.Value;
            else if (context is { DiameterCreateRange: not null, RandomizationAlgorithm: not null })
                self.Diameter = context.RandomizationAlgorithm.NextSingleInclusive(context.DiameterCreateRange.Start, context.DiameterCreateRange.End);
        });
    }

    public virtual Task GeneratePositionAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Position.HasValue)
                self.Position = context.Position.Value;
            else if (context is { PositionXCreateRange: not null, PositionYCreateRange: not null, PositionZCreateRange: not null, RandomizationAlgorithm: not null })
                self.Position = new Vector3(
                    context.RandomizationAlgorithm.NextSingleInclusive(context.PositionXCreateRange.Start, context.PositionXCreateRange.End),
                    context.RandomizationAlgorithm.NextSingleInclusive(context.PositionYCreateRange.Start, context.PositionYCreateRange.End),
                    context.RandomizationAlgorithm.NextSingleInclusive(context.PositionZCreateRange.Start, context.PositionZCreateRange.End)
                );
        });
    }

    public virtual Task GenerateOrientationAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Orientation.HasValue)
                self.Orientation = context.Orientation.Value;
            else if (context is { OrientationXCreateRange: not null, OrientationYCreateRange: not null, OrientationZCreateRange: not null, RandomizationAlgorithm: not null })
                self.Orientation = new Vector3(
                    context.RandomizationAlgorithm.NextSingleInclusive(context.OrientationXCreateRange.Start, context.OrientationXCreateRange.End),
                    context.RandomizationAlgorithm.NextSingleInclusive(context.OrientationYCreateRange.Start, context.OrientationYCreateRange.End),
                    context.RandomizationAlgorithm.NextSingleInclusive(context.OrientationZCreateRange.Start, context.OrientationZCreateRange.End)
                );
        });
    }

    public virtual Task GenerateAgeAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Age.HasValue)
                self.Age = context.Age.Value;
            else if (context is { AgeCreateRange: not null, RandomizationAlgorithm: not null })
                self.Age = context.RandomizationAlgorithm.NextSingleInclusive(context.AgeCreateRange.Start, context.AgeCreateRange.End);
        });
    }

    public virtual Task GenerateLifespanAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Lifespan.HasValue)
                self.Lifespan = context.Lifespan.Value;
            else if (context is { LifespanCreateRange: not null, RandomizationAlgorithm: not null })
                self.Lifespan = context.RandomizationAlgorithm.NextSingleInclusive(context.LifespanCreateRange.Start, context.LifespanCreateRange.End);
        });
    }

    public virtual Task GenerateMassAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Mass.HasValue)
                self.Mass = context.Mass.Value;
            else if (context is { MassCreateRange: not null, RandomizationAlgorithm: not null })
                self.Mass = context.RandomizationAlgorithm.NextDoubleInclusive(context.MassCreateRange.Start, context.MassCreateRange.End);
        });
    }

    public virtual Task GenerateLuminosityAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Luminosity.HasValue)
                self.Luminosity = context.Luminosity.Value;
            else if (context is { LuminosityCreateRange: not null, RandomizationAlgorithm: not null })
                self.Luminosity = context.RandomizationAlgorithm.NextSingleInclusive(context.LuminosityCreateRange.Start, context.LuminosityCreateRange.End);
        });
    }

    public virtual Task GenerateTemperatureAsync(TContext context, T self)
    {
        return Task.Run(() =>
        {
            if (context.Temperature.HasValue)
                self.Temperature = context.Temperature.Value;
            else if (context is { TemperatureCreateRange: not null, RandomizationAlgorithm: not null })
                self.Temperature = context.RandomizationAlgorithm.NextSingleInclusive(context.TemperatureCreateRange.Start, context.TemperatureCreateRange.End);
        });
    }

    protected virtual void GenerateBaseProperties(TContext context, T self)
    {
        SetMatterType(context, self);
        GenerateRandomGenerationAlgorithm(context, self);
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