

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

public abstract class TheoreticalAstronomicalObject : AstronomicalObject
{
    public TheoreticalAstronomicalObject()
    {

    }
    public override bool Theoretical { get; } = true;
}