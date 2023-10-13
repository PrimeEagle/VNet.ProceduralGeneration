namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class Filament : AstronomicalObjectGroup
{
    public float Length => BoundingBox.SideLength;
}