namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class Filament : AstronomicalObjectGroup, IFilament
{
    protected Filament()
    {

    }

    public float Length => BoundingBox.SideLength;
}