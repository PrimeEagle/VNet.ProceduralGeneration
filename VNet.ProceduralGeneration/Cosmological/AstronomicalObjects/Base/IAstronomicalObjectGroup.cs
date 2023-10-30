namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public interface IAstronomicalObjectGroup : IAstronomicalObject
{
    List<IAstronomicalObject> Children { get; set; }
}