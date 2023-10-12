using Diagnostics.Sizeof;
using System.Numerics;
using System.Text;
using VNet.Configuration;
using VNet.Mathematics.Randomization.Generation;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.Scientific.NumericalVolumes;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
// ReSharper disable PropertyCanBeMadeInitOnly.Global
// ReSharper disable UnassignedField.Global
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8629 // Nullable value type may be null.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public abstract class AstronomicalObject : IAstronomicalObject
    {
        protected float? age;
        protected float? lifespan;
        protected double? mass;
        protected float? diameter;
        protected float? temperature;
        protected float? luminosity;
        protected Vector3 position;
        protected Vector3? orientation;


        protected float? radius;
        protected double? volume;
        protected double? density;
        protected double? size;
        protected float? absoluteMagnitude;
        protected float? apparentMagnitude;
        protected double? displayAge;
        protected double? displayLifespan;
        protected double? displayMass;
        protected double? displayDiameter;
        protected double? displayRadius;
        protected double? displayDensity;
        protected double? displaySize;
        protected double? displayVolume;
        protected double? displayTemperature;
        protected float? displayLuminosity;
        protected Vector3? displayPosition;
        protected float? displayAbsoluteMagnitude;
        protected Vector3? apparentMagnitudeSource;

        protected readonly GeneratorSettings settings;

        #region Base Properties
        public string Id { get; init; }
        public bool Enabled { get; set; }
        public virtual float Age { get; set; }                                                      // years
        public virtual float Lifespan { get; set; }                                                 // years
        public virtual double Mass { get; set; }                                                    // kg
        public virtual float Diameter { get; set; }                                                 // AU
        public virtual float Temperature { get; set; }                                              // Kelvin
        public virtual float Luminosity { get; set; }                                               // L⊙
        public virtual Vector3 Position { get; set; }                                               // AU
        public virtual BoundingBox<float> BoundingBox { get; set; }
        public virtual Vector3 Orientation { get; set; }
        public MatterType MatterType { get; set; }
        public virtual float Radius                                                                 // AU
        {
            get
            {
                if(!radius.HasValue) CalculateRadius();
                return radius.Value;
            }
        }
        public virtual double Volume                                                                // AU³
        {
            get
            {
                if (!volume.HasValue) CalculateVolume();
                return volume.Value;
            }
        }
        public virtual double Density                                                               // kg/AU³
        {
            get
            {
                if (!density.HasValue) CalculateDensity();
                return density.Value;
            }
        }
        public virtual double Size                                                                  // AU or AU³
        {
            get
            {
                if (!size.HasValue) CalculateSize();
                return size.Value;
            }
        }
        public virtual float AbsoluteMagnitude
        {
            get
            {
                if (!absoluteMagnitude.HasValue) CalculateAbsoluteMagnitude();
                return absoluteMagnitude.Value;
            }
        }
        public virtual double DisplayAge
        {
            get
            {
                if (!displayAge.HasValue) CalculateDisplayAge();
                return displayAge.Value;
            }
        }
        public virtual double DisplayLifespan
        {
            get
            {
                if (!displayLifespan.HasValue) CalculateDisplayLifespan();
                return displayLifespan.Value;
            }
        }
        public virtual double DisplayMass
        {
            get
            {
                if (!displayMass.HasValue) CalculateDisplayMass();
                return displayMass.Value;
            }
        }
        public virtual double DisplayDiameter
        {
            get
            {
                if (!displayDiameter.HasValue) CalculateDisplayDiameter();
                return displayDiameter.Value;
            }
        }
        public virtual double DisplayTemperature
        {
            get
            {
                if (!displayTemperature.HasValue) CalculateDisplayTemperature();
                return displayTemperature.Value;
            }
        }
        public virtual double DisplayLuminosity
        {
            get
            {
                if (!displayLuminosity.HasValue) CalculateDisplayLuminosity();
                return displayLuminosity.Value;
            }
        }
        public virtual Vector3 DisplayPosition
        {
            get
            {
                if (!displayPosition.HasValue) CalculateDisplayPosition();
                return displayPosition.Value;
            }
        }
        public virtual double DisplayRadius
        {
            get
            {
                if (!displayRadius.HasValue) CalculateDisplayRadius();
                return displayRadius.Value;
            }
        }
        public virtual double DisplayVolume
        {
            get
            {
                if (!displayVolume.HasValue) CalculateDisplayVolume();
                return displayVolume.Value;
            }
        }
        public virtual double DisplayDensity
        {
            get
            {
                if(!displayDensity.HasValue) CalculateDisplayDensity();
                return displayDensity.Value;
            }
        }
        public virtual double DisplaySize
        {
            get
            {
                if (!displaySize.HasValue) CalculateDisplaySize();
                return displaySize.Value;
            }
        }
        public virtual double DisplayAbsoluteMagnitude
        {
            get
            {
                if (!displayAbsoluteMagnitude.HasValue) CalculateDisplayAbsoluteMagnitude();
                return displayAbsoluteMagnitude.Value;
            }
        }
#endregion Base Properties

        public AstronomicalObject Parent { get; set; }
        public Universe Universe => FindUniverse();
        protected AstronomicalObject()
        {
            this.Id = GenerateId();
            this.Enabled = true;
            settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
        }
        protected AstronomicalObject(AstronomicalObject parent)
        {
            this.Id = GenerateId();
            this.Parent = parent;
            this.Enabled = true;
            settings = ConfigurationSettings<GeneratorSettings>.AppSettings;
        }

        #region Property Calculation Methods
        protected virtual void CalculateRadius()
        {
            radius ??= this.Diameter / 2;
        }
        protected virtual void CalculateVolume()
        {
            volume = (4 / 3) * Math.PI * Math.Pow((this.Radius), 3);
        }
        protected virtual void CalculateDensity()
        {
            density = this.Mass / this.Volume;
        }
        protected virtual void CalculateSize()
        {
            size ??= settings.Advanced.Application.SizeMeaning switch
            {
                SizeType.Radius => this.Radius,
                SizeType.Diameter => this.Diameter,
                SizeType.Volume => this.Volume,
                _ => this.Diameter
            };
        }
        protected virtual void CalculateDisplayAge()
        {
            if (settings.Advanced.Application.TimeConversionFactor == 0)
            {
                displayAge = this.Age;
            }
            else
            {
                displayAge = this.Age * settings.Advanced.Application.TimeConversionFactor;
            }
        }
        protected virtual void CalculateAbsoluteMagnitude()
        {
            absoluteMagnitude ??= (float)(-2.5 * Math.Log10(this.Luminosity) + settings.Advanced.PhysicalConstants.C);
        }
        protected virtual void CalculateDisplayLifespan()
        {
            if (settings.Advanced.Application.TimeConversionFactor == 0)
            {
                displayLifespan = this.Lifespan;
            }
            else
            {
                displayLifespan = this.Lifespan * settings.Advanced.Application.TimeConversionFactor;
            }
        }
        protected virtual void CalculateDisplayMass()
        {
            if (settings.Advanced.Application.MassConversionFactor == 0)
            {
                displayMass = this.Mass;
            }
            else
            {
                displayMass = this.Mass * settings.Advanced.Application.MassConversionFactor;
            }
        }
        protected virtual void CalculateDisplayDiameter()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                displayDiameter = this.Diameter;
            }
            else
            {
                displayDiameter = this.Diameter * settings.Advanced.Application.LengthConversionFactor;
            }
        }
        protected virtual void CalculateDisplayTemperature()
        {
            if (settings.Advanced.Application.TemperatureConversionFactor == 0)
            {
                displayTemperature = this.Temperature;
            }
            else
            {
                displayTemperature = this.Temperature * settings.Advanced.Application.LengthConversionFactor;
            }
        }
        protected virtual void CalculateDisplayLuminosity()
        {
            if (settings.Advanced.Application.LuminosityConversionFactor == 0)
            {
                displayLuminosity = this.Luminosity;
            }
            else
            {
                displayLuminosity = this.Luminosity * settings.Advanced.Application.LuminosityConversionFactor;
            }
        }
        protected virtual void CalculateDisplayPosition()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                displayPosition = this.Position;
            }
            else
            {
                displayPosition = new Vector3(this.Position.X * (float)settings.Advanced.Application.LengthConversionFactor,
                    this.Position.Y * (float)settings.Advanced.Application.LengthConversionFactor,
                    this.Position.Z * (float)settings.Advanced.Application.LengthConversionFactor);
            }
        }
        protected virtual void CalculateDisplayRadius()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                displayRadius = this.Radius;
            }
            else
            {
                displayRadius = this.Diameter * settings.Advanced.Application.LengthConversionFactor;
            }
        }
        protected virtual void CalculateDisplayVolume()
        {
            if (settings.Advanced.Application.LengthConversionFactor == 0)
            {
                displayVolume = this.Volume;
            }
            else
            {
                displayVolume = this.Diameter * Math.Pow(settings.Advanced.Application.LengthConversionFactor, 3);
            }
        }
        protected virtual void CalculateDisplayDensity()
        {
            displayDensity = this.DisplayMass / this.DisplayVolume;
        }
        protected virtual void CalculateDisplaySize()
        {
            displaySize ??= settings.Advanced.Application.SizeMeaning switch
            {
                SizeType.Radius => this.DisplayRadius,
                SizeType.Diameter => this.DisplayDiameter,
                SizeType.Volume => this.DisplayVolume,
                _ => this.DisplayDiameter
            };
        }
        protected virtual void CalculateDisplayAbsoluteMagnitude()
        {
            displayAbsoluteMagnitude = this.AbsoluteMagnitude;
        }
        public virtual void RecalculateProperties()
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
        public float ApparentMagnitude(Vector3 source)
        {
            if (apparentMagnitudeSource == source && apparentMagnitude.HasValue) return apparentMagnitude.Value;

            apparentMagnitudeSource = source;
            var distanceAu = Vector3.Distance(this.Position, source);
            var distanceParsecs = distanceAu / 206265.0;
            apparentMagnitude = (float)(this.AbsoluteMagnitude + 5 * (Math.Log10(distanceParsecs) - 1));

            return apparentMagnitude.Value;
        }
        #endregion Property Calculation Methods

        public float EstimateMemorySize()
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

        public virtual void UpdateBoundingBox()
        {
            this.BoundingBox = new BoundingBox<float>(this.position, 1, Vector3.UnitZ);
        }
    }
}