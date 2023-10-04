using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public interface IAstronomicalObject
    {
        public string Id { get; init; }
        public float Age { get; set; }                                                      // years
        public float Lifespan { get; set; }                                                 // years
        public double Mass { get; set; }                                                    // kg
        public float Diameter { get; set; }                                                 // AU
        public float Temperature { get; set; }                                              // Kelvin
        public float Luminosity { get; set; }                                               // L⊙
        public Vector3 Position { get; set; }                                               // AU


        // calculated properties
        public float Radius { get; }                                                        // AU
        public double Volume { get; }                                                       // AU³
        public double Density { get; }                                                      // kg/AU³
        public double Size { get; }                                                         // AU or AU³
        public float AbsoluteMagnitude { get; } 
        public AstronomicalObject Parent { get; set; }
        public Universe Universe { get; }


        // display properties
        public double DisplayAge { get; }
        public double DisplayLifespan { get; }
        public double DisplayMass { get; }
        public double DisplayDiameter { get; }
        public double DisplayTemperature { get; }
        public double DisplayLuminosity { get; }
        public Vector3 DisplayPosition { get; }
        public double DisplayRadius { get; }
        public double DisplayVolume { get; }
        public double DisplayDensity { get; }
        public double DisplaySize { get; }
        public double DisplayAbsoluteMagnitude { get; }




        public float EstimateSize();
        public float ApparentMagnitude(Vector3 source);
        public void RecalculateProperties();
    }
}