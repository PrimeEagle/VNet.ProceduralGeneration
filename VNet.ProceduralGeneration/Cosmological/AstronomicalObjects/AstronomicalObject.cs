using Diagnostics.Sizeof;
using System.Numerics;
using System.Text;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public abstract class AstronomicalObject : IAstronomicalObject
    {
        protected GeneratorSettings settings;
        public string Id { get; init; }
        public bool Enabled { get; set; }
        public float Age { get; set; }                                                      // years
        public float Lifespan { get; set; }                                                 // years
        public double Mass { get; set; }                                                    // kg
        public float Diameter { get; set; }                                                 // AU
        public float Temperature { get; set; }                                              // Kelvin
        public double Luminosity { get; set; }                                              // L⊙
        public Vector3 Position { get; set; }                                               // AU


        // calculated properties
        public float Radius => this.Diameter / 2;                                           // AU
        public double Volume => (4 / 3) * Math.PI * Math.Pow((this.Radius), 3);             // AU³
        public double Density => this.Mass / this.Volume;                                   // kg/AU³
        public double Size                                                                  // AU or AU³
        {
            get
            {
                return settings.Advanced.Application.SizeMeaning switch
                {
                    SizeType.Radius => this.Radius,
                    SizeType.Diameter => this.Diameter,
                    SizeType.Volume => this.Volume,
                    _ => this.Diameter
                };
            }
        }
        public double AbsoluteMagnitude => -2.5 * Math.Log10(this.Luminosity) + settings.Advanced.Universe.C;
        public double DisplayAge
        {
            get
            {
                if (settings.Advanced.Application.TimeConversionFactor == 0)
                {
                    return this.Age;
                }
                else
                {
                    return this.Age * settings.Advanced.Application.TimeConversionFactor;
                }
            }
        }
        public double DisplayLifespan
        {
            get
            {
                if (settings.Advanced.Application.TimeConversionFactor == 0)
                {
                    return this.Lifespan;
                }
                else
                {
                    return this.Lifespan * settings.Advanced.Application.TimeConversionFactor;
                }
            }
        }
        public double DisplayMass
        {
            get
            {
                if (settings.Advanced.Application.MassConversionFactor == 0)
                {
                    return this.Mass;
                }
                else
                {
                    return this.Mass * settings.Advanced.Application.MassConversionFactor;
                }
            }
        }
        public double DisplayDiameter
        {
            get
            {
                if (settings.Advanced.Application.LengthConversionFactor == 0)
                {
                    return this.Diameter;
                }
                else
                {
                    return this.Diameter * settings.Advanced.Application.LengthConversionFactor;
                }
            }
        }
        public double DisplayTemperature
        {
            get
            {
                if (settings.Advanced.Application.TemperatureConversionFactor == 0)
                {
                    return this.Temperature;
                }
                else
                {
                    return this.Temperature * settings.Advanced.Application.LengthConversionFactor;
                }
            }
        }
        public double DisplayLuminosity
        {
            get
            {
                if (settings.Advanced.Application.LuminosityConversionFactor == 0)
                {
                    return this.Luminosity;
                }
                else
                {
                    return this.Luminosity * settings.Advanced.Application.LuminosityConversionFactor;
                }
            }
        }
        public Vector3 DisplayPosition
        {
            get
            {
                if (settings.Advanced.Application.LengthConversionFactor == 0)
                {
                    return this.Position;
                }
                else
                {
                    return new Vector3(this.Position.X * (float)settings.Advanced.Application.LengthConversionFactor, 
                                       this.Position.Y * (float)settings.Advanced.Application.LengthConversionFactor, 
                                       this.Position.Z * (float)settings.Advanced.Application.LengthConversionFactor);
                }
            }
        }
        public double DisplayRadius
        {
            get
            {
                if (settings.Advanced.Application.LengthConversionFactor == 0)
                {
                    return this.Radius;
                }
                else
                {
                    return this.Diameter * settings.Advanced.Application.LengthConversionFactor;
                }
            }
        }
        public double DisplayVolume
        {
            get
            {
                if (settings.Advanced.Application.LengthConversionFactor == 0)
                {
                    return this.Volume;
                }
                else
                {
                    return this.Diameter * Math.Pow(settings.Advanced.Application.LengthConversionFactor, 3);
                }
            }
        }
        public double DisplayDensity => this.DisplayMass / this.DisplayVolume;
        public double DisplaySize
        {
            get
            {
                return settings.Advanced.Application.SizeMeaning switch
                {
                    SizeType.Radius => this.DisplayRadius,
                    SizeType.Diameter => this.DisplayDiameter,
                    SizeType.Volume => this.DisplayVolume,
                    _ => this.DisplayDiameter
                };
            }
        }
        public double DisplayAbsoluteMagnitude => this.AbsoluteMagnitude;


        public AstronomicalObject Parent { get; set; }
        public List<AstronomicalObject> Children { get; set; }
        public Universe Universe => FindUniverse();




        protected AstronomicalObject()
        {
            this.Id = GenerateId();
            this.Enabled = true;
            this.Children = new List<AstronomicalObject>();
            settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
        }

        protected AstronomicalObject(AstronomicalObject parent)
        {
            this.Id = GenerateId();
            this.Parent = parent;
            this.Enabled = true;
            this.Children = new List<AstronomicalObject>();
            settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
        }

        public float EstimateSize()
        {
            return this.SizeInBytes();
        }
        private static string GenerateId()
        {
            var random = new DotNetGenerator();
            var ticks = DateTime.UtcNow.Ticks;
            ticks ^= (random.Next() << 8);
            var base36Ticks = Base36Encode(ticks);
            base36Ticks = base36Ticks.PadLeft(8, '0').Substring(base36Ticks.Length - 8, 8);

            return base36Ticks.Insert(4, "-");
        }
        private static string Base36Encode(long value)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = new StringBuilder();

            while (value > 0)
            {
                result.Insert(0, chars[(int)(value % 36)]);
                value /= 36;
            }

            return result.ToString();
        }
        private Universe FindUniverse()
        {
            var main = (AstronomicalObject)this;
            var parent = main.Parent;

            while (parent != null)
            {
                main = parent;
                parent = main.Parent;
            }

            return (Universe)main;
        }
        public double ApparentMagnitude(Vector3 source)
        {
            var distanceAU = Vector3.Distance(this.Position, source);
            var distanceParsecs = distanceAU / 206265.0;
            double apparentMagnitude = this.AbsoluteMagnitude + 5 * (Math.Log10(distanceParsecs) - 1);

            return apparentMagnitude;
        }
        internal abstract void AssignChildren();
    }
}