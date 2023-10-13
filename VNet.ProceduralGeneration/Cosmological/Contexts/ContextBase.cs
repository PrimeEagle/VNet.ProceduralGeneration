using System.Numerics;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.Scientific.NumericalVolumes;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable PropertyCanBeMadeInitOnly.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.Contexts
{
    public  abstract class ContextBase
    {
        public float ParentAge { get; set; }                                    // years
        public float ParentLifespan { get; set; }                               // years
        public double ParentMass { get; set; }                                  // kg
        public float ParentDiameter { get; set; }                               // AU
        public float ParentTemperature { get; set; }                            // Kelvin
        public float ParentLuminosity { get; set; }                             //  L⊙
        public Vector3 ParentPosition { get; set; }                             // AU
        public Vector3 ParentOrientation { get; set; }
        public float? Age { get; set; }                                         // years
        public float? Lifespan { get; set; }                                    // years
        public double? Mass { get; set; }                                       // kg
        public float? Diameter { get; set; }                                    // AU
        public float? Temperature { get; set; }                                 // Kelvin
        public float? Luminosity { get; set; }                                  //  L⊙
        public Vector3? Position { get; set; }                                  // AU
        public Vector3? Orientation { get; set; }
        public (float, float)? AgeCreateRange { get; set; }                     // years
        public (float, float)? LifespanCreateRange { get; set; }                // years
        public (double, double)? MassCreateRange { get; set; }                  // kg
        public (float, float)? DiameterCreateRange { get; set; }                // AU
        public (float, float)? TemperatureCreateRange { get; set; }             // Kelvin
        public (float, float)? LuminosityCreateRange { get; set; }              //  L⊙
        public (float, float)? PositionXCreateRange { get; set; }               // AU
        public (float, float)? PositionYCreateRange { get; set; }               // AU
        public (float, float)? PositionZCreateRange { get; set; }               // AU
        public (float, float)? OrientationXCreateRange { get; set; }
        public (float, float)? OrientationYCreateRange { get; set; }
        public (float, float)? OrientationZCreateRange { get; set; }
        public IRandomGenerationAlgorithm RandomizationAlgorithm { get; set; }



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