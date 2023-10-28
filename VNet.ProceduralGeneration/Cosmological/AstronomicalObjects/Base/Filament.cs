namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class Filament : AstronomicalObjectGroup
{
    protected Filament()
    {

    }

    public float Length => BoundingBox.SideLength;
}