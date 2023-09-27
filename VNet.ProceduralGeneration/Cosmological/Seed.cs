using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class Seed
    {
        public Vector3 Position { get; set; }
        public float Intensity { get; set; }

        public Seed(Vector3 position, float intensity)
        {
            Position = position;
            Intensity = intensity;
        }
    }
}