using Diagnostics.Sizeof;
using System.Numerics;
using System.Text;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable UnassignedField.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;


public abstract class AstronomicalObject : IAstronomicalObject
{
    protected float? absoluteMagnitude;
    protected float? age;
    protected float? lifespan;
    protected float? luminosity;
    protected double? mass;
    protected Vector3 position;
    protected float? temperature;

    protected AstronomicalObject()
    {
        Id = GenerateId();
        Enabled = true;
    }

    protected AstronomicalObject(AstronomicalObject parent)
    {
        Id = GenerateId();
        Parent = parent;
        Enabled = true;
    }

    public virtual bool Theoretical { get; } = false;
    public AstronomicalObject? Parent { get; set; }
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

    #region Base Properties

    public string Id { get; init; }
    public bool Enabled { get; set; }
    public virtual float Age { get; set; }                                          // years
    public virtual float Lifespan { get; set; }                                     // years
    public virtual double Mass { get; set; }                                        // kg
    public virtual float Diameter { get; set; }                                     // AU
    public virtual float Temperature { get; set; }                                  // Kelvin
    public virtual float Luminosity { get; set; }                                   // L⊙
    public virtual Vector3 Position { get; set; }                                   // AU
    public virtual BoundingBox<float> BoundingBox { get; set; }
    public virtual Vector3 Orientation { get; set; }
    public MatterType MatterType { get; set; }
    public IRandomGenerationAlgorithm RandomGenerationAlgorithm { get; set; }

    #endregion Base Properties
}