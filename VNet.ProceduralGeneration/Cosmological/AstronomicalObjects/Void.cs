using System.Numerics;
using VNet.Scientific.NumericalVolumes;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public abstract class Void : AstronomicalObjectContainer
{
    public override void UpdateBoundingBox()
    {
        this.BoundingBox = new BoundingBox<float>(this.Position, 1, Vector3.UnitZ * this.Diameter);
    }
}