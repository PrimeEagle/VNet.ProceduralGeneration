using System.Numerics;
using System.Text;
using Diagnostics.Sizeof;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable UnassignedField.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8629 // Nullable value type may be null.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class AstronomicalObject : IAstronomicalObject
{
    protected readonly GeneratorSettings settings;
    protected float? absoluteMagnitude;
    protected float? age;
    protected float? apparentMagnitude;
    protected Vector3? apparentMagnitudeSource;
    protected double? density;
    protected float? diameter;
    protected float? displayAbsoluteMagnitude;
    protected double? displayAge;
    protected double? displayDensity;
    protected double? displayDiameter;
    protected double? displayLifespan;
    protected float? displayLuminosity;
    protected double? displayMass;
    protected Vector3? displayPosition;
    protected double? displayRadius;
    protected double? displaySize;
    protected double? displayTemperature;
    protected double? displayVolume;
    protected float? lifespan;
    protected float? luminosity;
    protected double? mass;
    protected Vector3? orientation;
    protected Vector3 position;


    protected float? radius;
    protected double? size;
    protected float? temperature;
    protected double? volume;

    protected AstronomicalObject()
    {
        Id = GenerateId();
        Enabled = true;
        settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
    }

    protected AstronomicalObject(AstronomicalObject parent)
    {
        Id = GenerateId();
        Parent = parent;
        Enabled = true;
        settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
    }

    public AstronomicalObject Parent { get; set; }
    public Universe Universe => FindUniverse();

    public float EstimateMemorySize()
    {
        return this.SizeInBytes();
    }

    public virtual void UpdateBoundingBox()
    {
        BoundingBox = new BoundingBox<float>(position, 1, Vector3.UnitZ);
    }

    private static string GenerateId()
    {
        var random = new DotNetGenerator();
        var ticks = DateTime.UtcNow.Ticks;
        ticks ^= random.Next() << 8;
        var base36Ticks = Base36Encode(ticks);
        base36Ticks = base36Ticks.PadLeft(8, '0').Substring(base36Ticks.Length - 8, 8);

        return base36Ticks.Insert(4, "-");
    }

    private static string Base36Encode(long value)
    {
        const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        var result = new StringBuilder();

        while (value > 0)
        {
            result.Insert(0, chars[(int)(value % 36)]);
            value /= 36;
        }

        return result.ToString();
    }

    private Universe FindUniverse()
    {
        var main = this;
        var parent = main.Parent;

        while (parent != null)
        {
            main = parent;
            parent = main.Parent;
        }

        return (Universe)main;
    }

    internal abstract void AssignChildren();

    #region Base Properties

    public string Id { get; init; }
    public bool Enabled { get; set; }
    public virtual float Age { get; set; } // years
    public virtual float Lifespan { get; set; } // years
    public virtual double Mass { get; set; } // kg
    public virtual float Diameter { get; set; } // AU
    public virtual float Temperature { get; set; } // Kelvin
    public virtual float Luminosity { get; set; } // L⊙
    public virtual Vector3 Position { get; set; } // AU
    public virtual BoundingBox<float> BoundingBox { get; set; }
    public virtual Vector3 Orientation { get; set; }
    public MatterType MatterType { get; set; }

    public virtual float Radius // AU
    {
        get
        {
            if (!radius.HasValue) CalculateRadius();
            return radius.Value;
        }
    }

    public virtual double Volume // AU³
    {
        get
        {
            if (!volume.HasValue) CalculateVolume();
            return volume.Value;
        }
    }

    public virtual double Density // kg/AU³
    {
        get
        {
            if (!density.HasValue) CalculateDensity();
            return density.Value;
        }
    }

    public virtual double Size // AU or AU³
    {
        get
        {
            if (!size.HasValue) CalculateSize();
            return size.Value;
        }
    }

    public virtual float AbsoluteMagnitude
    {
        get
        {
            if (!absoluteMagnitude.HasValue) CalculateAbsoluteMagnitude();
            return absoluteMagnitude.Value;
        }
    }

    public virtual double DisplayAge
    {
        get
        {
            if (!displayAge.HasValue) CalculateDisplayAge();
            return displayAge.Value;
        }
    }

    public virtual double DisplayLifespan
    {
        get
        {
            if (!displayLifespan.HasValue) CalculateDisplayLifespan();
            return displayLifespan.Value;
        }
    }

    public virtual double DisplayMass
    {
        get
        {
            if (!displayMass.HasValue) CalculateDisplayMass();
            return displayMass.Value;
        }
    }

    public virtual double DisplayDiameter
    {
        get
        {
            if (!displayDiameter.HasValue) CalculateDisplayDiameter();
            return displayDiameter.Value;
        }
    }

    public virtual double DisplayTemperature
    {
        get
        {
            if (!displayTemperature.HasValue) CalculateDisplayTemperature();
            return displayTemperature.Value;
        }
    }

    public virtual double DisplayLuminosity
    {
        get
        {
            if (!displayLuminosity.HasValue) CalculateDisplayLuminosity();
            return displayLuminosity.Value;
        }
    }

    public virtual Vector3 DisplayPosition
    {
        get
        {
            if (!displayPosition.HasValue) CalculateDisplayPosition();
            return displayPosition.Value;
        }
    }

    public virtual double DisplayRadius
    {
        get
        {
            if (!displayRadius.HasValue) CalculateDisplayRadius();
            return displayRadius.Value;
        }
    }

    public virtual double DisplayVolume
    {
        get
        {
            if (!displayVolume.HasValue) CalculateDisplayVolume();
            return displayVolume.Value;
        }
    }

    public virtual double DisplayDensity
    {
        get
        {
            if (!displayDensity.HasValue) CalculateDisplayDensity();
            return displayDensity.Value;
        }
    }

    public virtual double DisplaySize
    {
        get
        {
            if (!displaySize.HasValue) CalculateDisplaySize();
            return displaySize.Value;
        }
    }

    public virtual double DisplayAbsoluteMagnitude
    {
        get
        {
            if (!displayAbsoluteMagnitude.HasValue) CalculateDisplayAbsoluteMagnitude();
            return displayAbsoluteMagnitude.Value;
        }
    }

    #endregion Base Properties

    #region Property Calculation Methods

    protected virtual void CalculateRadius()
    {
        radius ??= Diameter / 2;
    }

    protected virtual void CalculateVolume()
    {
        volume = 4 / 3 * Math.PI * Math.Pow(Radius, 3);
    }

    protected virtual void CalculateDensity()
    {
        density = Mass / Volume;
    }

    protected virtual void CalculateSize()
    {
        size ??= settings.Advanced.Application.SizeMeaning switch
        {
            SizeType.Radius => Radius,
            SizeType.Diameter => Diameter,
            SizeType.Volume => Volume,
            _ => Diameter
        };
    }

    protected virtual void CalculateDisplayAge()
    {
        if (settings.Advanced.Application.TimeConversionFactor == 0)
            displayAge = Age;
        else
            displayAge = Age * settings.Advanced.Application.TimeConversionFactor;
    }

    protected virtual void CalculateAbsoluteMagnitude()
    {
        absoluteMagnitude ??= (float)(-2.5 * Math.Log10(Luminosity) + settings.Advanced.PhysicalConstants.C);
    }

    protected virtual void CalculateDisplayLifespan()
    {
        if (settings.Advanced.Application.TimeConversionFactor == 0)
            displayLifespan = Lifespan;
        else
            displayLifespan = Lifespan * settings.Advanced.Application.TimeConversionFactor;
    }

    protected virtual void CalculateDisplayMass()
    {
        if (settings.Advanced.Application.MassConversionFactor == 0)
            displayMass = Mass;
        else
            displayMass = Mass * settings.Advanced.Application.MassConversionFactor;
    }

    protected virtual void CalculateDisplayDiameter()
    {
        if (settings.Advanced.Application.LengthConversionFactor == 0)
            displayDiameter = Diameter;
        else
            displayDiameter = Diameter * settings.Advanced.Application.LengthConversionFactor;
    }

    protected virtual void CalculateDisplayTemperature()
    {
        if (settings.Advanced.Application.TemperatureConversionFactor == 0)
            displayTemperature = Temperature;
        else
            displayTemperature = Temperature * settings.Advanced.Application.LengthConversionFactor;
    }

    protected virtual void CalculateDisplayLuminosity()
    {
        if (settings.Advanced.Application.LuminosityConversionFactor == 0)
            displayLuminosity = Luminosity;
        else
            displayLuminosity = Luminosity * settings.Advanced.Application.LuminosityConversionFactor;
    }

    protected virtual void CalculateDisplayPosition()
    {
        if (settings.Advanced.Application.LengthConversionFactor == 0)
            displayPosition = Position;
        else
            displayPosition = new Vector3(Position.X * (float)settings.Advanced.Application.LengthConversionFactor,
                Position.Y * (float)settings.Advanced.Application.LengthConversionFactor,
                Position.Z * (float)settings.Advanced.Application.LengthConversionFactor);
    }

    protected virtual void CalculateDisplayRadius()
    {
        if (settings.Advanced.Application.LengthConversionFactor == 0)
            displayRadius = Radius;
        else
            displayRadius = Diameter * settings.Advanced.Application.LengthConversionFactor;
    }

    protected virtual void CalculateDisplayVolume()
    {
        if (settings.Advanced.Application.LengthConversionFactor == 0)
            displayVolume = Volume;
        else
            displayVolume = Diameter * Math.Pow(settings.Advanced.Application.LengthConversionFactor, 3);
    }

    protected virtual void CalculateDisplayDensity()
    {
        displayDensity = DisplayMass / DisplayVolume;
    }

    protected virtual void CalculateDisplaySize()
    {
        displaySize ??= settings.Advanced.Application.SizeMeaning switch
        {
            SizeType.Radius => DisplayRadius,
            SizeType.Diameter => DisplayDiameter,
            SizeType.Volume => DisplayVolume,
            _ => DisplayDiameter
        };
    }

    protected virtual void CalculateDisplayAbsoluteMagnitude()
    {
        displayAbsoluteMagnitude = AbsoluteMagnitude;
    }

    public virtual void RecalculateProperties()
    {
        CalculateRadius();
        CalculateVolume();
        CalculateDensity();
        CalculateSize();
        CalculateAbsoluteMagnitude();
        CalculateDisplayAge();
        CalculateDisplayLifespan();
        CalculateDisplayMass();
        CalculateDisplayDiameter();
        CalculateDisplayTemperature();
        CalculateDisplayLuminosity();
        CalculateDisplayPosition();
        CalculateDisplayRadius();
        CalculateDisplayVolume();
        CalculateDisplayDensity();
        CalculateDisplaySize();
        CalculateDisplayAbsoluteMagnitude();
    }

    public float ApparentMagnitude(Vector3 source)
    {
        if (apparentMagnitudeSource == source && apparentMagnitude.HasValue) return apparentMagnitude.Value;

        apparentMagnitudeSource = source;
        var distanceAu = Vector3.Distance(Position, source);
        var distanceParsecs = distanceAu / 206265.0;
        apparentMagnitude = (float)(AbsoluteMagnitude + 5 * (Math.Log10(distanceParsecs) - 1));

        return apparentMagnitude.Value;
    }

    #endregion Property Calculation Methods
}