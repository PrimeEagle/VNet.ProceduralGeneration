namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class Sheet : AstronomicalObjectGroup, ISheet
{
    protected Sheet()
    {

    }
    public float Thickness { get; set; }
}