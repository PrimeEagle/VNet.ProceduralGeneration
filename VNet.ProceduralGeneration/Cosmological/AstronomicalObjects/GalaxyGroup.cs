namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public class GalaxyGroup : AstronomicalObject
    {
        public List<Galaxy> Galaxies { get; set; } = new();
    }
}