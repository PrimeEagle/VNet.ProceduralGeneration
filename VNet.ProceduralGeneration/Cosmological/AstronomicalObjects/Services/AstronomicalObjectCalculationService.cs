using Microsoft.Extensions.Logging;
using System.Numerics;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Enum;

// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NotAccessedField.Local


namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services
{
    public class AstronomicalObjectCalculationService
    {
        protected readonly IConfigurationService ConfigurationService;
        protected readonly ILogger<AstronomicalObjectCalculationService> Logger;




        public AstronomicalObjectCalculationService(IConfigurationService configurationService, ILogger<AstronomicalObjectCalculationService> logger)
        {
            ConfigurationService = configurationService;
            Logger = logger;
        }

        public virtual double CalculateSize(AstronomicalObject astroObject)
        {
            return ConfigurationService.GetConfiguration<ApplicationSettings>().SizeMeaning switch
            {
                SizeType.Radius => CalculateRadius(astroObject),
                SizeType.Diameter => astroObject.Diameter,
                SizeType.Volume => CalculateVolume(astroObject),
                _ => astroObject.Diameter
            };
        }

        public virtual double CalculateDisplayAge(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor == 0)
                return astroObject.Age;
            else
                return astroObject.Age * ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor;
        }

        public virtual float CalculateAbsoluteMagnitude(AstronomicalObject astroObject)
        {
            return (float)(-2.5 * Math.Log10(astroObject.Luminosity) + ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().C);
        }

        public virtual double CalculateDisplayLifespan(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor == 0)
                return astroObject.Lifespan;
            else
                return astroObject.Lifespan * ConfigurationService.GetConfiguration<ApplicationSettings>().TimeConversionFactor;
        }

        public virtual double CalculateDisplayMass(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().MassConversionFactor == 0)
                return astroObject.Mass;
            else
                return astroObject.Mass * ConfigurationService.GetConfiguration<ApplicationSettings>().MassConversionFactor;
        }

        public virtual double CalculateDisplayDiameter(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return astroObject.Diameter;
            else
                return astroObject.Diameter * ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor;
        }

        public virtual double CalculateDisplayTemperature(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().TemperatureConversionFactor == 0)
                return astroObject.Temperature;
            else
                return astroObject.Temperature * ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor;
        }

        public virtual float CalculateDisplayLuminosity(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LuminosityConversionFactor == 0)
                return astroObject.Luminosity;
            else
                return astroObject.Luminosity * ConfigurationService.GetConfiguration<ApplicationSettings>().LuminosityConversionFactor;
        }

        public virtual Vector3 CalculateDisplayPosition(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return astroObject.Position;
            else
                return new Vector3(astroObject.Position.X * (float)ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor,
                    astroObject.Position.Y * (float)ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor,
                    astroObject.Position.Z * (float)ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor);
        }

        public virtual double CalculateDisplayRadius(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return CalculateRadius(astroObject);
            else
                return astroObject.Diameter * ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor;
        }

        public virtual double CalculateDisplayVolume(AstronomicalObject astroObject)
        {
            if (ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor == 0)
                return CalculateVolume(astroObject);
            else
                return astroObject.Diameter * Math.Pow(ConfigurationService.GetConfiguration<ApplicationSettings>().LengthConversionFactor, 3);
        }

        public virtual double CalculateDisplaySize(AstronomicalObject astroObject)
        {
            return ConfigurationService.GetConfiguration<ApplicationSettings>().SizeMeaning switch
            {
                SizeType.Radius => CalculateDisplayRadius(astroObject),
                SizeType.Diameter => CalculateDisplayDiameter(astroObject),
                SizeType.Volume => CalculateDisplayVolume(astroObject),
                _ => CalculateDisplayDiameter(astroObject)
            };
        }

        public virtual double CalculateDisplayDensity(AstronomicalObject astroObject)
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

        public virtual double CalculateRadius(AstronomicalObject astroObject)
        {
            return astroObject.Diameter / 2;
        }

        public virtual double CalculateVolume(AstronomicalObject astroObject)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(CalculateRadius(astroObject), 3);
        }

        public virtual double CalculateDensity(AstronomicalObject astroObject)
        {
            return astroObject.Mass / CalculateVolume(astroObject);
        }

        public virtual float CalculateDisplayAbsoluteMagnitude(AstronomicalObject astroObject)
        {
            return CalculateAbsoluteMagnitude(astroObject);
        }
    }
}