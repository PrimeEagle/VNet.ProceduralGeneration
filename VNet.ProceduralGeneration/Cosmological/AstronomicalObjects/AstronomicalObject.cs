using System.Numerics;
using Diagnostics.Sizeof;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public abstract class AstronomicalObject : IAstronomicalObject
    {
        public float Age { get; set; }                      // years
        public double Mass { get; set; }                    // kg
        public float Size { get; set; }                     // AU
        public double Magnitude { get; set; }               // 
        public double Temperature { get; set; }             // Kelvin
        public Vector3 Position { get; set; }               // AU
        public float Lifespan { get; set; }                 // years
        public IAstronomicalObject Parent { get; set; }


        protected AstronomicalObject()
        {

        }

        protected AstronomicalObject(IAstronomicalObject parent)
        {
            this.Parent = parent;
        }

        public float EstimateSize()
        {
            return this.SizeInBytes();
        }
    }
}