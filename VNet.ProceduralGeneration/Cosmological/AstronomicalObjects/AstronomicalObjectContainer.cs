using System.Numerics;
using VNet.Scientific.NumericalVolumes;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable InconsistentNaming
#pragma warning disable CS8629 // Nullable value type may be null.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public abstract class AstronomicalObjectContainer : AstronomicalObject
    {
        #region Base Properties

        public override float Age                                                                    // years
        {
            get
            {
                if (!age.HasValue) CalculateAge();
                return age.Value;
            }
        }

        public override float Lifespan                                                               // years
        {
            get
            {
                if (!lifespan.HasValue) CalculateLifespan();
                return lifespan.Value;
            }
        }

        public override double Mass                                                                  // kg
        {
            get
            {
                if (!mass.HasValue) CalculateMass();
                return mass.Value;
            }
        }

        public override float Luminosity                                                             // L⊙
        {
            get
            {
                if (!luminosity.HasValue) CalculateLuminosity();
                return luminosity.Value;
            }
        }

        public override float Temperature                                                            // Kelvin
        {
            get
            {
                if (!temperature.HasValue) CalculateTemperature();
                return temperature.Value;
            }
        }
        public override float AbsoluteMagnitude
        {
            get
            {
                if (!absoluteMagnitude.HasValue) CalculateAbsoluteMagnitude();
                return absoluteMagnitude.Value;
            }
        }
        public virtual Vector3 Orientation { get; set; }
        public virtual BoundingBox<float> BoundingBox { get; set; }
        public List<Vector3> Points { get; set; }

        #endregion Base Properties

        #region Property Calculation Methods
        protected virtual void CalculateAge()
        {
            age = this.Children.Max(c => c.Age);
        }
        protected virtual void CalculateLifespan()
        {
            age = this.Children.Max(c => c.Lifespan);
        }

        protected virtual void CalculateMass()
        {
            mass = this.Children.Sum(c => c.Mass);
        }

        protected virtual void CalculateLuminosity()
        {
            luminosity = this.Children.Sum(c => c.Luminosity);
        }

        protected virtual void CalculateTemperature()
        {
            temperature = this.Children.Sum(c => c.Luminosity * c.Temperature) / this.Luminosity;
        }

        protected override void CalculateAbsoluteMagnitude()
        {
            absoluteMagnitude = (float)(-2.5 * Math.Log10(this.Luminosity) + settings.Advanced.PhysicalConstants.C);
        }
        
        public override void RecalculateProperties()
        {
            base.RecalculateProperties();
            CalculateAge();
            CalculateLifespan();
            CalculateMass();
            CalculateLuminosity();
            CalculateAbsoluteMagnitude();
            CalculateTemperature();
        }
        #endregion Property Calculation Methods

        protected AstronomicalObjectContainer() : base()
        {
            this.Points = new List<Vector3>();
        }
        protected AstronomicalObjectContainer(AstronomicalObject parent) : base(parent)
        {
            this.Points = new List<Vector3>();
        }
    }
}