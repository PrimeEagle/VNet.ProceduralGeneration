//namespace VNet.ProceduralGeneration.Geological;

//public static class TemperatureMap
//{
//    // Gravitational constant (m^3 / kg s^2)
//    private const double G = 6.6743e-11;

//    // Boltzmann constant (J / K)
//    private const double K = 1.38064852e-23;

//    // Solar mass (kg)
//    private const double SOLAR_MASS = 1.98847e30;

//    // Solar radius (m)
//    private const double SOLAR_RADIUS = 6.957e8;

//    // Planck constant (J s)
//    private const double PLANCK = 6.62607015e-34;

//    // Speed of light (m / s)
//    private const double SPEED_OF_LIGHT = 299792458;

//    public static double[,] Generate(int width, int height, double planetRadius, double starRadius, double starTemperature, double starDistance, double atmosphereDensity)
//    {
//        double[,] temperatureMap = new double[width, height];

//        // Calculate the mass of the star
//        double starMass = 4.0 / 3.0 * Math.PI * Math.Pow(starRadius, 3) * 1408.0;

//        // Calculate the luminosity of the star
//        double luminosity = 4.0 * Math.PI * Math.Pow(starRadius, 2) * PLANCK * Math.Pow(starTemperature, 4) / (SPEED_OF_LIGHT * 1e9);

//        // Calculate the effective temperature of the planet
//        double effectiveTemperature = Math.Pow(luminosity / (16.0 * Math.PI * G * Math.Pow(starDistance * 1e9, 2)), 0.25);

//        // Calculate the temperature gradient of the atmosphere
//        double temperatureGradient = Math.Pow((effectiveTemperature / planetRadius) * (K / (atmosphereDensity * G * starMass / Math.Pow(planetRadius, 2))), 0.25);

//        // Generate the temperature map for each pixel
//        for (int y = 0; y < height; y++)
//        {
//            for (int x = 0; x < width; x++)
//            {
//                // Calculate the distance from the center of the planet to the current pixel
//                double distance = Math.Sqrt(Math.Pow(x - width / 2.0, 2) + Math.Pow(y - height / 2.0, 2));

//                // Calculate the temperature at the current pixel based on the distance and temperature gradient
//                temperatureMap[x, y] = effectiveTemperature - distance * temperatureGradient;
//            }
//        }

//        return temperatureMap;
//    }
//}

