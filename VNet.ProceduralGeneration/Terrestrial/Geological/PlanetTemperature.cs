//namespace VNet.ProceduralGeneration.Geological;

//public class PlanetTemperature
//{
//    private double planetRadius; // in meters
//    private double starRadius; // in meters
//    private double starTemperature; // in Kelvin
//    private double starDistance; // in meters
//    private double[,] heightMap; // in meters
//    private double atmosphereDensity; // in kg/m^3

//    private const double BoltzmannConstant = 1.380649e-23; // in J/K
//    private const double EarthAverageSurfaceTemperature = 288.16; // in Kelvin
//    private const double EarthAverageAtmosphereTemperatureLapseRate = 6.5e-3; // in K/m

//    public PlanetTemperature(double planetRadius, double starRadius, double starTemperature, double starDistance, double[,] heightMap, double atmosphereDensity)
//    {
//        this.planetRadius = planetRadius;
//        this.starRadius = starRadius;
//        this.starTemperature = starTemperature;
//        this.starDistance = starDistance;
//        this.heightMap = heightMap;
//        this.atmosphereDensity = atmosphereDensity;
//    }

//    public double[,] GenerateTemperatureMap()
//    {
//        int heightMapWidth = heightMap.GetLength(0);
//        int heightMapHeight = heightMap.GetLength(1);

//        double[,] temperatureMap = new double[heightMapWidth, heightMapHeight];

//        double planetSurfaceArea = 4 * Math.PI * planetRadius * planetRadius;

//        for (int x = 0; x < heightMapWidth; x++)
//        {
//            for (int y = 0; y < heightMapHeight; y++)
//            {
//                double height = heightMap[x, y];
//                double distanceFromStar = starDistance + height;

//                // Calculate the effective temperature of the star
//                double effectiveTemperature = starTemperature * Math.Sqrt(starRadius / (2 * distanceFromStar));

//                // Calculate the temperature of the planet's surface based on its distance from the star
//                double planetSurfaceTemperature = effectiveTemperature * Math.Pow(starRadius / distanceFromStar, 0.5);

//                // Calculate the atmospheric temperature based on lapse rate and height
//                double atmosphereHeight = height - planetRadius;
//                double atmosphereTemperatureLapse = EarthAverageAtmosphereTemperatureLapseRate;
//                double atmosphereTemperature = EarthAverageSurfaceTemperature - atmosphereHeight * atmosphereTemperatureLapse;

//                // Calculate the temperature of the air above water, which is cooler than the temperature of the air above land
//                double waterHeight = 0.0;
//                if (height < waterHeight)
//                {
//                    double waterTemperatureLapse = -0.0065; // in K/m, water temperature lapse rate is different than land temperature lapse rate
//                    double waterTemperature = EarthAverageSurfaceTemperature - (waterHeight - height) * waterTemperatureLapse;
//                    atmosphereTemperature = waterTemperature;
//                }

//                // Calculate the temperature of the air at this point in the atmosphere
//                double airTemperature = planetSurfaceTemperature + ((atmosphereTemperature - planetSurfaceTemperature) * Math.Exp(-atmosphereDensity * BoltzmannConstant * (atmosphereHeight) / (effectiveTemperature)));

//                temperatureMap[x, y] = airTemperature;
//            }
//        }

//        return temperatureMap;
//    }
//}

