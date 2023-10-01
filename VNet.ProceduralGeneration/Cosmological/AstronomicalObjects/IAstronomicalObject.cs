using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public interface IAstronomicalObject
    {
        public float Age { get; set; }
        public double Mass { get; set; }
        public float Size { get; set; }
        public double Magnitude { get; set; }
        public double Temperature { get; set; }
        public Vector3 Position { get; set; }
        public float Lifespan { get; set; }
        public IAstronomicalObject Parent { get; set; }




        public float EstimateSize();
    }
}