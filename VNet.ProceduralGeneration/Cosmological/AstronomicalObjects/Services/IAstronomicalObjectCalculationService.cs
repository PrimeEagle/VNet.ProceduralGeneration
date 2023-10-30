using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Services;

public interface IAstronomicalObjectCalculationService
{
    double CalculateSize(AstronomicalObject astroObject);
    double CalculateDisplayAge(AstronomicalObject astroObject);
    float CalculateAbsoluteMagnitude(AstronomicalObject astroObject);
    double CalculateDisplayLifespan(AstronomicalObject astroObject);
    double CalculateDisplayMass(AstronomicalObject astroObject);
    double CalculateDisplayDiameter(AstronomicalObject astroObject);
    double CalculateDisplayTemperature(AstronomicalObject astroObject);
    float CalculateDisplayLuminosity(AstronomicalObject astroObject);
    Vector3 CalculateDisplayPosition(AstronomicalObject astroObject);
    double CalculateDisplayRadius(AstronomicalObject astroObject);
    double CalculateDisplayVolume(AstronomicalObject astroObject);
    double CalculateDisplaySize(AstronomicalObject astroObject);
    double CalculateDisplayDensity(AstronomicalObject astroObject);
    float CalculateApparentMagnitude(Vector3 source, AstronomicalObject astroObject);
    double CalculateRadius(AstronomicalObject astroObject);
    double CalculateVolume(AstronomicalObject astroObject);
    double CalculateDensity(AstronomicalObject astroObject);
    float CalculateDisplayAbsoluteMagnitude(AstronomicalObject astroObject);
}