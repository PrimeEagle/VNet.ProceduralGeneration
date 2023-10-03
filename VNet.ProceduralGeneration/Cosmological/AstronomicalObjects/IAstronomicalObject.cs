using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public interface IAstronomicalObject
    {
        public string Id { get; init; }
        public float Age { get; set; }
        public double Mass { get; set; }
        public float Size { get; set; }
        public float Temperature { get; set; }
        public Vector3 Position { get; set; }
        public float Lifespan { get; set; }
        public float AbsoluteMagnitude { get; set; }
        public AstronomicalObject Parent { get; set; }
        public Universe Universe { get; }




        public float EstimateSize();
    }
}