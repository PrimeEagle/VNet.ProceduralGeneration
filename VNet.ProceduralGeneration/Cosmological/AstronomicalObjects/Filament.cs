using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

public abstract class Filament : AstronomicalObjectContainer
{
    public float Length => this.BoundingBox.SideLength;





    protected Filament() : base()
    {
        
    }
}