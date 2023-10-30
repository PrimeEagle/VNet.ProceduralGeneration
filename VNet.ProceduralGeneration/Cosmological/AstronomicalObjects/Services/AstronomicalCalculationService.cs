using Microsoft.Extensions.Logging;
using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Enum;

// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NotAccessedField.Local
// ReSharper disable UnusedParameter.Global


namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services
{
    public class AstronomicalCalculationService : IAstronomicalCalculationService
    {
        protected readonly IConfigurationService ConfigurationService;
        protected readonly ILogger<AstronomicalCalculationService> Logger;




        public AstronomicalCalculationService(IConfigurationService configurationService, ILogger<AstronomicalCalculationService> logger)
        {
            ConfigurationService = configurationService;
            Logger = logger;
        }

        public virtual double CalculateSize(IAstronomicalObject astroObject)
        {
            return ConfigurationService.GetConfiguration<ApplicationSettings>().SizeMeaning switch
            {
                SizeType.Radius => CalculateRadius(astroObject),
                SizeType.Diameter => astroObject.Diameter,
                SizeType.Volume => CalculateVolume(astroObject),
                _ => astroObject.Diameter
            };
        }

        public virtual double CalculateDisplayAge(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor == 0)
                return astroObject.Age;
            else
                return astroObject.Age * ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor;
        }

        public virtual float CalculateAbsoluteMagnitude(IAstronomicalObject astroObject)
        {
            return (float)(-2.5 * Math.Log10(astroObject.Luminosity) + ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().C);
        }

        public virtual double CalculateDisplayLifespan(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor == 0)
                return astroObject.Lifespan;
            else
                return astroObject.Lifespan * ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor;
        }

        public virtual double CalculateDisplayMass(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().MassConversionFactor == 0)
                return astroObject.Mass;
            else
                return astroObject.Mass * ConfigurationService.GetConfiguration<ApplicationSettings>().MassConversionFactor;
        }

        public virtual double CalculateDisplayDiameter(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return astroObject.Diameter;
            else
                return astroObject.Diameter * ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor;
        }

        public virtual double CalculateDisplayTemperature(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().TemperatureConversionFactor == 0)
                return astroObject.Temperature;
            else
                return astroObject.Temperature * ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor;
        }

        public virtual float CalculateDisplayLuminosity(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LuminosityConversionFactor == 0)
                return astroObject.Luminosity;
            else
                return astroObject.Luminosity * ConfigurationService.GetConfiguration<ApplicationSettings>().LuminosityConversionFactor;
        }

        public virtual Vector3 CalculateDisplayPosition(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return astroObject.Position;
            else
                return new Vector3(astroObject.Position.X * (float)ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor,
                    astroObject.Position.Y * (float)ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor,
                    astroObject.Position.Z * (float)ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor);
        }

        public virtual double CalculateDisplayRadius(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return CalculateRadius(astroObject);
            else
                return astroObject.Diameter * ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor;
        }

        public virtual double CalculateDisplayVolume(IAstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return CalculateVolume(astroObject);
            else
                return astroObject.Diameter * Math.Pow(ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor, 3);
        }

        public virtual double CalculateDisplaySize(IAstronomicalObject astroObject)
        {
            return ConfigurationService.GetConfiguration<ApplicationSettings>().SizeMeaning switch
            {
                SizeType.Radius => CalculateDisplayRadius(astroObject),
                SizeType.Diameter => CalculateDisplayDiameter(astroObject),
                SizeType.Volume => CalculateDisplayVolume(astroObject),
                _ => CalculateDisplayDiameter(astroObject)
            };
        }

        public virtual double CalculateDisplayDensity(IAstronomicalObject astroObject)
        {
            return CalculateDisplayMass(astroObject) / CalculateDisplayVolume(astroObject);
        }

        public virtual float CalculateApparentMagnitude(Vector3 source, AstronomicalObject astroObject)
        {
            var distanceAu = Vector3.Distance(astroObject.Position, source);
            var distanceParsecs = distanceAu / 206265.0;
            var apparentMagnitude = (float)(CalculateAbsoluteMagnitude(astroObject) + 5 * (Math.Log10(distanceParsecs) - 1));

            return apparentMagnitude;
        }

        public virtual float CalculateRadius(IAstronomicalObject astroObject)
        {
            return astroObject.Diameter / 2;
        }

        public virtual double CalculateVolume(IAstronomicalObject astroObject)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(CalculateRadius(astroObject), 3);
        }

        public virtual double CalculateDensity(IAstronomicalObject astroObject)
        {
            return astroObject.Mass / CalculateVolume(astroObject);
        }

        public virtual float CalculateDisplayAbsoluteMagnitude(IAstronomicalObject astroObject)
        {
            return CalculateAbsoluteMagnitude(astroObject);
        }

        public double CalculateUniverseVolume(Universe universe)
        {
            return universe.DimensionX * universe.DimensionY * universe.DimensionZ;
        }

        public double CalculateUniverseCriticalDensity() // kg/AU³
        {
            return 3 * Math.Pow(1.496e11, 3) * Math.Pow(ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().H0 * 2.09e-13, 2) / (8 * Math.PI * ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().G);
        }

        public double CalculateUniverseExpansionRate(Universe universe) // kg/s/Mpc
        {
            var omegaB = universe.BaryonicMatterPercent / 100.0;
            var omegaDm = universe.DarkMatterPercent / 100.0;
            var omegaLambda = universe.DarkEnergyPercent / 100.0;

            var h2 = Math.Pow(ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().H0, 2) * (omegaB + omegaDm + omegaLambda);

            return Math.Sqrt(h2);
        }

        public float CalculateUniverseCmbVariations(Universe universe) // Kelvin
        {
            return Math.Abs(ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().BaselineCosmicMicrowaveBackground - universe.CosmicMicrowaveBackground);
        }

        public bool CalculateUniverseInflationOccurred(Universe universe)
        {
            return ConfigurationService.GetConfiguration<UniverseSettings>().InflationRange.Start > 0;
        }

        public float CalculateGroupAbsoluteMagnitude(IAstronomicalObjectGroup group)
        {
            return (float)(-2.5 * Math.Log10(CalculateGroupLuminosity(group)) + ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().C);
        }

        public float CalculateGroupAge(IAstronomicalObjectGroup group)
        {
            return group.Children.Max(c => c.Age);
        }

        public float CalculateGroupLifespan(IAstronomicalObjectGroup group)
        {
            return group.Children.Max(c => c.Lifespan);
        }

        public double CalculateGroupMass(IAstronomicalObjectGroup group)
        {
            return group.Children.Sum(c => c.Mass);
        }

        public float CalculateGroupLuminosity(IAstronomicalObjectGroup group)
        {
            return group.Children.Sum(c => c.Luminosity);
        }

        public float CalculateGroupTemperature(IAstronomicalObjectGroup group)
        {
            return group.Children.Sum(c => c.Luminosity * c.Temperature) / CalculateGroupLuminosity(group);
        }
    }
}