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
}