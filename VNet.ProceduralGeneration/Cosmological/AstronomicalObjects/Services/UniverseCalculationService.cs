using Microsoft.Extensions.Logging;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration.AstronomicalObjects;

// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBeMadeStatic.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable NotAccessedField.Local
#pragma warning disable CA1822


namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services
{
    public interface IUniverseCalculationService
    {
    }

    public class UniverseCalculationService : AstronomicalObjectCalculationService
    {
        public UniverseCalculationService(IConfigurationService configurationService, ILogger<AstronomicalObjectCalculationService> logger) : base(configurationService, logger)
        {
        }

        public double CalculateVolume(Universe universe)
        {
            return universe.DimensionX * universe.DimensionY * universe.DimensionZ;
        }

        public double CalculateCriticalDensity() // kg/AU³
        {
            return 3 * Math.Pow(1.496e11, 3) * Math.Pow(ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().H0 * 2.09e-13, 2) / (8 * Math.PI * ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().G);
        }

        public double CalculateExpansionRate(Universe universe) // kg/s/Mpc
        {
            var omegaB = universe.BaryonicMatterPercent / 100.0;
            var omegaDm = universe.DarkMatterPercent / 100.0;
            var omegaLambda = universe.DarkEnergyPercent / 100.0;

            var h2 = Math.Pow(ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().H0, 2) * (omegaB + omegaDm + omegaLambda);

            return Math.Sqrt(h2);
        }

        public float CalculateCmbVariations(Universe universe) // Kelvin
        {
            return Math.Abs(ConfigurationService.GetConfiguration<PhysicalConstantsSettings>().BaselineCosmicMicrowaveBackground - universe.CosmicMicrowaveBackground);
        }

        public bool CalculateInflationOccurred(Universe universe)
        {
            return ConfigurationService.GetConfiguration<UniverseSettings>().InflationRange.Start > 0;
        }
    }
}