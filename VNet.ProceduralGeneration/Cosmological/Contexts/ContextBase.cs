using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
// ReSharper disable MemberCanBePrivate.Global

namespace VNet.ProceduralGeneration.Cosmological.Contexts
{
    public  abstract class ContextBase
    {
        public float Age { get; set; }                      // years
        public float Lifespan { get; set; }                 // years
        public double Mass { get; set; }                    // kg
        public float Diameter { get; set; }                 // AU
        public float Temperature { get; set; }              // Kelvin
        public float Luminosity { get; set; }               //  L⊙
        public Vector3 Position { get; set; }               // AU
        public Vector3 Orientation { get; set; }



        protected virtual void LoadBaseProperties(AstronomicalObject astronomicalObject)
        {
            this.Age= astronomicalObject.Age;
            this.Lifespan = astronomicalObject.Lifespan;
            this.Mass = astronomicalObject.Mass;
            this.Diameter = astronomicalObject.Diameter;
            this.Temperature = astronomicalObject.Temperature;
            this.Luminosity = astronomicalObject.Luminosity;
            this.Position = astronomicalObject.Position;
            this.Orientation = astronomicalObject.Orientation;
        }
    }
}