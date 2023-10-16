using System.Numerics;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.Contexts.Base;

public abstract class ContextBase
{
    public float ParentAge { get; set; } // years
    public float ParentLifespan { get; set; } // years
    public double ParentMass { get; set; } // kg
    public float ParentDiameter { get; set; } // AU
    public float ParentTemperature { get; set; } // Kelvin
    public float ParentLuminosity { get; set; } //  L⊙
    public Vector3 ParentPosition { get; set; } // AU
    public Vector3 ParentOrientation { get; set; }
    public float? Age { get; set; } // years
    public float? Lifespan { get; set; } // years
    public double? Mass { get; set; } // kg
    public float? Diameter { get; set; } // AU
    public float? Temperature { get; set; } // Kelvin
    public float? Luminosity { get; set; } //  L⊙
    public Vector3? Position { get; set; } // AU
    public Vector3? Orientation { get; set; }
    public VNet.Configuration.Range<float>? AgeCreateRange { get; set; } // years
    public VNet.Configuration.Range<float>? LifespanCreateRange { get; set; } // years
    public VNet.Configuration.Range<double>? MassCreateRange { get; set; } // kg
    public VNet.Configuration.Range<float>? DiameterCreateRange { get; set; } // AU
    public VNet.Configuration.Range<float>? TemperatureCreateRange { get; set; } // Kelvin
    public VNet.Configuration.Range<float>? LuminosityCreateRange { get; set; } //  L⊙
    public VNet.Configuration.Range<float>? PositionXCreateRange { get; set; } // AU
    public VNet.Configuration.Range<float>? PositionYCreateRange { get; set; } // AU
    public VNet.Configuration.Range<float>? PositionZCreateRange { get; set; } // AU
    public VNet.Configuration.Range<float>? OrientationXCreateRange { get; set; }
    public VNet.Configuration.Range<float>? OrientationYCreateRange { get; set; }
    public VNet.Configuration.Range<float>? OrientationZCreateRange { get; set; }
    public IRandomGenerationAlgorithm RandomizationAlgorithm { get; set; }


    protected virtual void LoadBaseProperties(AstronomicalObject astronomicalObject)
    {
        Age = astronomicalObject.Age;
        Lifespan = astronomicalObject.Lifespan;
        Mass = astronomicalObject.Mass;
        Diameter = astronomicalObject.Diameter;
        Temperature = astronomicalObject.Temperature;
        Luminosity = astronomicalObject.Luminosity;
        Position = astronomicalObject.Position;
        Orientation = astronomicalObject.Orientation;
    }
}