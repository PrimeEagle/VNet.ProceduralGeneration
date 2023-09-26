using Diagnostics.Sizeof;
using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public abstract class AstronomicalObject
    {
        public float Age { get; set; }                      // years
        public double Mass { get; set; }                    // kg
        public float Size { get; set; }                     // AU
        public double Magnitude { get; set; }               // 
        public double Temperature { get; set; }             // Kelvin
        public Vector3 Position { get; set; }               // AU


        public float EstimateSize()
        {
            return this.SizeInBytes();
        }
    }
}