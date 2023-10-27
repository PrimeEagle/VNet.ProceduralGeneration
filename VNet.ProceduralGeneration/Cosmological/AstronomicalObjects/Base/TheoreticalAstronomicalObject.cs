namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class TheoreticalAstronomicalObject : AstronomicalObject
{
    public override bool Theoretical { get; } = true;
}