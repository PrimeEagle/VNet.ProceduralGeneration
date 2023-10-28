using System.Numerics;
using VNet.Scientific.NumericalVolumes;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class Void : AstronomicalObjectGroup, IVoid
{
    protected Void()
    {

    }
    public override void UpdateBoundingBox()
    {
        BoundingBox = new BoundingBox<float>(Position, 1, Vector3.UnitZ * Diameter);
    }
}