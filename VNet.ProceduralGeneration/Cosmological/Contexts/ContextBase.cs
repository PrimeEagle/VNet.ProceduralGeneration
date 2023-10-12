using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;

namespace VNet.ProceduralGeneration.Cosmological.Contexts
{
    public  abstract class ContextBase
    {
        public float Age { get; set; }                      // years
        public double Mass { get; set; }                    // kg
        public double Size { get; set; }                     // AU
        public float AbsoluteMagnitude { get; set; }        // 
        public float Luminosity { get; set; }              //  L⊙
        public float Temperature { get; set; }              // Kelvin
        public Vector3 Position { get; set; }               // AU



        protected virtual void LoadBaseProperties(AstronomicalObject astronomicalObject)
        {
            this.Age= astronomicalObject.Age;
            this.Mass = astronomicalObject.Mass;
            this.Size = astronomicalObject.Size;
            this.AbsoluteMagnitude = astronomicalObject.AbsoluteMagnitude;
            this.Temperature = astronomicalObject.Temperature;
            this.Position = astronomicalObject.Position;
        }
    }
}