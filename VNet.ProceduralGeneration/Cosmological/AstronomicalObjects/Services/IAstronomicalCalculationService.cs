using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;

public interface IAstronomicalCalculationService
{
    double CalculateSize(IAstronomicalObject astroObject);
    double CalculateDisplayAge(IAstronomicalObject astroObject);
    float CalculateAbsoluteMagnitude(IAstronomicalObject astroObject);
    double CalculateDisplayLifespan(IAstronomicalObject astroObject);
    double CalculateDisplayMass(IAstronomicalObject astroObject);
    double CalculateDisplayDiameter(IAstronomicalObject astroObject);
    double CalculateDisplayTemperature(IAstronomicalObject astroObject);
    float CalculateDisplayLuminosity(IAstronomicalObject astroObject);
    Vector3 CalculateDisplayPosition(IAstronomicalObject astroObject);
    double CalculateDisplayRadius(IAstronomicalObject astroObject);
    double CalculateDisplayVolume(IAstronomicalObject astroObject);
    double CalculateDisplaySize(IAstronomicalObject astroObject);
    double CalculateDisplayDensity(IAstronomicalObject astroObject);
    float CalculateApparentMagnitude(Vector3 source, AstronomicalObject astroObject);
    float CalculateRadius(IAstronomicalObject astroObject);
    double CalculateVolume(IAstronomicalObject astroObject);
    double CalculateDensity(IAstronomicalObject astroObject);
    float CalculateDisplayAbsoluteMagnitude(IAstronomicalObject astroObject);
    double CalculateUniverseVolume(Universe universe);
    double CalculateUniverseCriticalDensity(); // kg/AU³
    double CalculateUniverseExpansionRate(Universe universe); // kg/s/Mpc
    float CalculateUniverseCmbVariations(Universe universe); // Kelvin
    bool CalculateUniverseInflationOccurred(Universe universe);
    float CalculateGroupAbsoluteMagnitude(IAstronomicalObjectGroup group);
    float CalculateGroupAge(IAstronomicalObjectGroup group);
    float CalculateGroupLifespan(IAstronomicalObjectGroup group);
    double CalculateGroupMass(IAstronomicalObjectGroup group);
    float CalculateGroupLuminosity(IAstronomicalObjectGroup group);
    float CalculateGroupTemperature(IAstronomicalObjectGroup group);
    Task<double> CalculateSizeAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayAgeAsync(IAstronomicalObject astroObject);
    Task<float> CalculateAbsoluteMagnitudeAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayLifespanAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayMassAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayDiameterAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayTemperatureAsync(IAstronomicalObject astroObject);
    Task<float> CalculateDisplayLuminosityAsync(IAstronomicalObject astroObject);
    Task<Vector3> CalculateDisplayPositionAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayRadiusAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayVolumeAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplaySizeAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDisplayDensityAsync(IAstronomicalObject astroObject);
    Task<float> CalculateApparentMagnitudeAsync(Vector3 source, AstronomicalObject astroObject);
    Task<double> CalculateRadiusAsync(IAstronomicalObject astroObject);
    Task<double> CalculateVolumeAsync(IAstronomicalObject astroObject);
    Task<double> CalculateDensityAsync(IAstronomicalObject astroObject);
    Task<float> CalculateDisplayAbsoluteMagnitudeAsync(IAstronomicalObject astroObject);
    Task<double> CalculateUniverseVolumeAsync(Universe universe);
    Task<double> CalculateUniverseCriticalDensityAsync(); // kg/AU³
    Task<double> CalculateUniverseExpansionRateAsync(Universe universe); // kg/s/Mpc
    Task<float> CalculateUniverseCmbVariationsAsync(Universe universe); // Kelvin
    Task<bool> CalculateUniverseInflationOccurredAsync(Universe universe);
    Task<float> CalculateGroupAbsoluteMagnitudeAsync(IAstronomicalObjectGroup group);
    Task<float> CalculateGroupAgeAsync(IAstronomicalObjectGroup group);
    Task<float> CalculateGroupLifespanAsync(IAstronomicalObjectGroup group);
    Task<double> CalculateGroupMassAsync(IAstronomicalObjectGroup group);
    Task<float> CalculateGroupLuminosityAsync(IAstronomicalObjectGroup group);
    Task<float> CalculateGroupTemperatureAsync(IAstronomicalObjectGroup group);
}