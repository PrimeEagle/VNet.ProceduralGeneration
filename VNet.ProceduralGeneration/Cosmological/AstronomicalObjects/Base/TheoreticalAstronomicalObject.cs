namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class TheoreticalAstronomicalObject : AstronomicalObject
{
    protected TheoreticalAstronomicalObject()
    {

    }
    public override bool Theoretical { get; } = true;
}