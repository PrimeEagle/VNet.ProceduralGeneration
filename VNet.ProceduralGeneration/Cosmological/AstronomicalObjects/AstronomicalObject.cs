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
        private float? _radius;
        private double? _volume;
        private double? _density;
        private double? _size;
        private float? _absoluteMagnitude;
        private float? _apparentMagnitude;
        private double? _displayAge;
        private double? _displayLifespan;
        private double? _displayMass;
        private double? _displayDiameter;
        private double? _displayRadius;
        private double? _displayDensity;
        private double? _displaySize;
        private double? _displayVolume;
        private double? _displayTemperature;
        private float? _displayLuminosity;
        private Vector3? _displayPosition;
        private float? _displayAbsoluteMagnitude;
        private Vector3? _apparentMagnitudeSource;

        protected GeneratorSettings settings;
        public string Id { get; init; }
        public bool Enabled { get; set; }
        public float Age { get; set; }                                                      // years
        public float Lifespan { get; set; }                                                 // years
        public virtual double Mass { get; set; }                                            // kg
        public float Diameter { get; set; }                                                 // AU
        public float Temperature { get; set; }                                              // Kelvin
        public float Luminosity { get; set; }                                               // L⊙
        public Vector3 Position { get; set; }                                               // AU


        // calculated properties
        public float Radius                                                                 // AU
        {
            get
            {
                if(!_radius.HasValue) CalculateRadius();
                return _radius.Value;
            }
        }

        public double Volume                                                                // AU³
        {
            get
            {
                if (!_volume.HasValue) CalculateVolume();
                return _volume.Value;
            }
        }

        public double Density                                                               // kg/AU³
        {
            get
            {
                if (!_density.HasValue) CalculateDensity();
                return _density.Value;
            }
        }

        public double Size                                                                  // AU or AU³
        {
            get
            {
                if (!_size.HasValue) CalculateSize();
                return _size.Value;
            }
        }

        public float AbsoluteMagnitude
        {
            get
            {
                if (!_absoluteMagnitude.HasValue) CalculateAbsoluteMagnitude();
                return _absoluteMagnitude.Value;
            }
        }

        public double DisplayAge
        {
            get
            {
                if (!_displayAge.HasValue) CalculateDisplayAge();
                return _displayAge.Value;
            }
        }

        public double DisplayLifespan
        {
            get
            {
                if (!_displayLifespan.HasValue) CalculateDisplayLifespan();
                return _displayLifespan.Value;
            }
        }

        public double DisplayMass
        {
            get
            {
                if (!_displayMass.HasValue) CalculateDisplayMass();
                return _displayMass.Value;
            }
        }

        public double DisplayDiameter
        {
            get
            {
                if (!_displayDiameter.HasValue) CalculateDisplayDiameter();
                return _displayDiameter.Value;
            }
        }

        public double DisplayTemperature
        {
            get
            {
                if (!_displayTemperature.HasValue) CalculateDisplayTemperature();
                return _displayTemperature.Value;
            }
        }

        public double DisplayLuminosity
        {
            get
            {
                if (!_displayLuminosity.HasValue) CalculateDisplayLuminosity();
                return _displayLuminosity.Value;
            }
        }

        public Vector3 DisplayPosition
        {
            get
            {
                if (!_displayPosition.HasValue) CalculateDisplayPosition();
                return _displayPosition.Value;
            }
        }

        public double DisplayRadius
        {
            get
            {
                if (!_displayRadius.HasValue) CalculateDisplayRadius();
                return _displayRadius.Value;
            }
        }

        public double DisplayVolume
        {
            get
            {
                if (!_displayVolume.HasValue) CalculateDisplayVolume();
                return _displayVolume.Value;
            }
        }

        public double DisplayDensity
        {
            get
            {
                if(!_displayDensity.HasValue) CalculateDisplayDensity();
                return _displayDensity.Value;
            }
        }

        public double DisplaySize
        {
            get
            {
                if (!_displaySize.HasValue) CalculateDisplaySize();
                return _displaySize.Value;
            }
        }

        public double DisplayAbsoluteMagnitude
        {
            get
            {
                if (!_displayAbsoluteMagnitude.HasValue) CalculateDisplayAbsoluteMagnitude();
                return _displayAbsoluteMagnitude.Value;
            }
        }

        public float ApparentMagnitude(Vector3 source)
        {
            if (_apparentMagnitudeSource == source && _apparentMagnitude.HasValue) return _apparentMagnitude.Value;

            _apparentMagnitudeSource = source;
            var distanceAu = Vector3.Distance(this.Position, source);
            var distanceParsecs = distanceAu / 206265.0;
            _apparentMagnitude = (float)(this.AbsoluteMagnitude + 5 * (Math.Log10(distanceParsecs) - 1));

            return _apparentMagnitude.Value;
        }

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
        private void CalculateRadius()
        {
            _radius ??= this.Diameter / 2;
        }
        private void CalculateVolume()
        {
            _volume = (4 / 3) * Math.PI * Math.Pow((this.Radius), 3);
        }
        private void CalculateDensity()
        {
            _density = this.Mass / this.Volume;
        }
        private void CalculateSize()
        {
            _size ??= settings.Advanced.Application.SizeMeaning switch
            {
                SizeType.Radius => this.Radius,
                SizeType.Diameter => this.Diameter,
                SizeType.Volume => this.Volume,
                _ => this.Diameter
            };
        }
        private void CalculateDisplayAge()
        {
            if (settings.Advanced.Application.TimeConversionFactor == 0)
            {
                _displayAge = this.Age;
            }
            else
            {
                _displayAge = this.Age * settings.Advanced.Application.TimeConversionFactor;
            }
        }
        private void CalculateAbsoluteMagnitude()
        {
            _absoluteMagnitude ??= (float)(-2.5 * Math.Log10(this.Luminosity) + settings.Advanced.PhysicalConstants.C);
        }
        private void CalculateDisplayLifespan()
        {
            if (settings.Advanced.Application.TimeConversionFactor == 0)
            {
                _displayLifespan = this.Lifespan;
            }
            else
            {
                _displayLifespan = this.Lifespan * settings.Advanced.Application.TimeConversionFactor;
            }
        }
        private void CalculateDisplayMass()
        {
            if (settings.Advanced.Application.MassConversionFactor == 0)
            {
                _displayMass = this.Mass;
            }
            else
            {
                _displayMass = this.Mass * settings.Advanced.Application.MassConversionFactor;
            }
        }
        private void CalculateDisplayDiameter()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                _displayDiameter = this.Diameter;
            }
            else
            {
                _displayDiameter = this.Diameter * settings.Advanced.Application.LengthConversionFactor;
            }
        }
        private void CalculateDisplayTemperature()
        {
            if (settings.Advanced.Application.TemperatureConversionFactor == 0)
            {
                _displayTemperature = this.Temperature;
            }
            else
            {
                _displayTemperature = this.Temperature * settings.Advanced.Application.LengthConversionFactor;
            }
        }
        private void CalculateDisplayLuminosity()
        {
            if (settings.Advanced.Application.LuminosityConversionFactor == 0)
            {
                _displayLuminosity = this.Luminosity;
            }
            else
            {
                _displayLuminosity = this.Luminosity * settings.Advanced.Application.LuminosityConversionFactor;
            }
        }
        private void CalculateDisplayPosition()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                _displayPosition = this.Position;
            }
            else
            {
                _displayPosition = new Vector3(this.Position.X * (float)settings.Advanced.Application.LengthConversionFactor,
                    this.Position.Y * (float)settings.Advanced.Application.LengthConversionFactor,
                    this.Position.Z * (float)settings.Advanced.Application.LengthConversionFactor);
            }
        }
        private void CalculateDisplayRadius()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                _displayRadius = this.Radius;
            }
            else
            {
                _displayRadius = this.Diameter * settings.Advanced.Application.LengthConversionFactor;
            }
        }
        private void CalculateDisplayVolume()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                _displayVolume = this.Volume;
            }
            else
            {
                _displayVolume = this.Diameter * Math.Pow(settings.Advanced.Application.LengthConversionFactor, 3);
            }
        }
        private void CalculateDisplayDensity()
        {
            _displayDensity = this.DisplayMass / this.DisplayVolume;
        }
        private void CalculateDisplaySize()
        {
            _displaySize ??= settings.Advanced.Application.SizeMeaning switch
            {
                SizeType.Radius => this.DisplayRadius,
                SizeType.Diameter => this.DisplayDiameter,
                SizeType.Volume => this.DisplayVolume,
                _ => this.DisplayDiameter
            };
        }
        private void CalculateDisplayAbsoluteMagnitude()
        {
            _displayAbsoluteMagnitude = this.AbsoluteMagnitude;
        }
        public void RecalculateProperties()
        {
            CalculateRadius();
            CalculateVolume();
            CalculateDensity();
            CalculateSize();
            CalculateAbsoluteMagnitude();
            CalculateDisplayAge();
            CalculateDisplayLifespan();
            CalculateDisplayMass();
            CalculateDisplayDiameter();
            CalculateDisplayTemperature();
            CalculateDisplayLuminosity();
            CalculateDisplayPosition();
            CalculateDisplayRadius();
            CalculateDisplayVolume();
            CalculateDisplayDensity();
            CalculateDisplaySize();
            CalculateDisplayAbsoluteMagnitude();
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
        internal abstract void AssignChildren();
    }
}