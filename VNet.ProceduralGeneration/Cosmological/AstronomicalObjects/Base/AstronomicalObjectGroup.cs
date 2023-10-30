using System.Numerics;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.Noise;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable CollectionNeverQueried.Global
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

    public virtual INoiseAlgorithm? SurfaceNoiseAlgorithm { get; set; }
    public virtual IRandomGenerationAlgorithm? InteriorRandomizationAlgorithm { get; set; }

    internal List<IAstronomicalObject> Children { get; set; }

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

    #endregion Property Calculation Methods
}