namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public class GalaxyGroup : AstronomicalObjectContainer
    {
        public List<Galaxy> Galaxies { get; set; } = new();
    }
}