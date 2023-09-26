using Diagnostics.Sizeof;
using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public abstract class AstronomicalObject
    {
        public float Age { get; set; }
        public double Mass { get; set; }
        public double Magnitude { get; set; }
        public double Temperature { get; set; }
        public Vector3 Position { get; set; }


        public float EstimateSize()
        {
            return this.SizeInBytes();
        }
    }
}