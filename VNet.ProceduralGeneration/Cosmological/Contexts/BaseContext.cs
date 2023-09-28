using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public  abstract class BaseContext
    {
        public float Age { get; set; }                      // years
        public double Mass { get; set; }                    // kg
        public float Size { get; set; }                     // AU
        public double Magnitude { get; set; }               // 
        public double Temperature { get; set; }             // Kelvin
        public Vector3 Position { get; set; }               // AU



        protected void LoadBaseProperties(AstronomicalObject astronomicalObject)
        {
            this.Age= astronomicalObject.Age;
            this.Mass = astronomicalObject.Mass;
            this.Size = astronomicalObject.Size;
            this.Magnitude = astronomicalObject.Magnitude;
            this.Temperature = astronomicalObject.Temperature;
            this.Position = astronomicalObject.Position;
        }
    }
}