using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.Enum;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverQueried.Global
#pragma warning disable CS8629 // Nullable value type may be null.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class AstronomicalObjectGroup : AstronomicalObject
{
    protected AstronomicalObjectGroup()
    {
        MatterType = MatterType.None;
    }

    protected AstronomicalObjectGroup(AstronomicalObject parent) : base(parent)
    {
        MatterType = MatterType.None;
    }

    #region Base Properties

    public override float Age // years
    {
        get
        {
            if (!age.HasValue) CalculateAge();
            return age.Value;
        }
    }

    public override float Lifespan // years
    {
        get
        {
            if (!lifespan.HasValue) CalculateLifespan();
            return lifespan.Value;
        }
    }

    public override double Mass // kg
    {
        get
        {
            if (!mass.HasValue) CalculateMass();
            return mass.Value;
        }
    }

    public override float Luminosity // L⊙
    {
        get
        {
            if (!luminosity.HasValue) CalculateLuminosity();
            return luminosity.Value;
        }
    }

    public override float Temperature // Kelvin
    {
        get
        {
            if (!temperature.HasValue) CalculateTemperature();
            return temperature.Value;
        }
    }

    public override float AbsoluteMagnitude
    {
        get
        {
            if (!absoluteMagnitude.HasValue) CalculateAbsoluteMagnitude();
            return absoluteMagnitude.Value;
        }
    }

    protected List<AstronomicalObject> Children { get; set; }

    public List<IUndefinedAstronomicalObject> InteriorObjects { get; set; }

    public List<Vector3> WarpedSurface { get; set; }

    #endregion Base Properties

    #region Property Calculation Methods

    protected virtual void CalculateAge()
    {
        age = Children.Max(c => c.Age);
    }

    protected virtual void CalculateLifespan()
    {
        age = Children.Max(c => c.Lifespan);
    }

    protected virtual void CalculateMass()
    {
        mass = Children.Sum(c => c.Mass);
    }

    protected virtual void CalculateLuminosity()
    {
        luminosity = Children.Sum(c => c.Luminosity);
    }

    protected virtual void CalculateTemperature()
    {
        temperature = Children.Sum(c => c.Luminosity * c.Temperature) / Luminosity;
    }

    protected override void CalculateAbsoluteMagnitude()
    {
        absoluteMagnitude = (float)(-2.5 * Math.Log10(Luminosity) + settings.Advanced.PhysicalConstants.C);
    }

    public override void RecalculateProperties()
    {
        base.RecalculateProperties();
        CalculateAge();
        CalculateLifespan();
        CalculateMass();
        CalculateLuminosity();
        CalculateAbsoluteMagnitude();
        CalculateTemperature();
    }

    #endregion Property Calculation Methods
}