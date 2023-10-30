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

    public List<IAstronomicalObject> Children { get; set; }

    public List<IUndefinedAstronomicalObject> InteriorObjects { get; set; }

    public List<Vector3> WarpedSurface { get; set; }

    #endregion Base Properties
}