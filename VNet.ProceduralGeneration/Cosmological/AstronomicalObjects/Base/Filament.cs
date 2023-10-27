

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class Filament : AstronomicalObjectGroup
{
    public Filament()
    {

    }

    public float Length => BoundingBox.SideLength;
}