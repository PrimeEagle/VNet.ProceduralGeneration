//namespace VNet.ProceduralGeneration.Geological;

//class HeatMap
//{
//    public HeatMap()
//    {
//        // Define variables
//        double planetSize = 10000; // km
//        double rotationSpeed = 1000; // km/h
//        double distanceFromStar = 149.6e6; // km
//        double starSize = 1.989e30; // kg (mass of the Sun)
//        double starTemperature = 5778; // K (temperature of the Sun)

//        // Calculate surface temperature of the planet
//        double distanceRatio = Math.Pow(distanceFromStar / 149.6e6, 2);
//        double temperatureRatio = Math.Pow(starSize / 1.989e30, 0.25) * Math.Pow(starTemperature / 5778, 0.5);
//        double surfaceTemperature = temperatureRatio / Math.Sqrt(planetSize / 6378) * Math.Sqrt(rotationSpeed / 1670) * Math.Sqrt(distanceRatio);

//        // Generate heat map
//        int numRows = 100;
//        int numCols = 100;
//        double[,] heatMap = new double[numRows, numCols];

//        for (int i = 0; i < numRows; i++)
//        {
//            for (int j = 0; j < numCols; j++)
//            {
//                double latitude = (i * 180.0 / (numRows - 1)) - 90.0;
//                double longitude = (j * 360.0 / (numCols - 1)) - 180.0;

//                double temperature = surfaceTemperature * Math.Cos(latitude * Math.PI / 180.0);
//                heatMap[i, j] = temperature;
//            }
//        }

//        // Print heat map
//        for (int i = 0; i < numRows; i++)
//        {
//            for (int j = 0; j < numCols; j++)
//            {
//                Console.Write("{0:F2}\t", heatMap[i, j]);
//            }
//            Console.WriteLine();
//        }
//    }
//}

