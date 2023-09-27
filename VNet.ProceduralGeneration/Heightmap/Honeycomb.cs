using System.Drawing;


namespace VNet.ProceduralGeneration.Heightmap
{
    public class Honeycomb
    {
        private static Random _random = new Random();

        public static Bitmap GenerateHeightMap(
            int width,
            int height,
            int minHexSize,
            int maxHexSize,
            int hexOffsetVariation,
            double maxDistColorFactor)
        {
            Bitmap heightMap = new Bitmap(width, height);
            int hexHeight = (int)(Math.Sqrt(3) * minHexSize);

            for (int y = 0; y < height; y += hexHeight)
            {
                for (int x = 0; x < width; x += (int)Math.Round(maxHexSize * 1.5))
                {
                    int centerX = x + (_random.Next(-hexOffsetVariation, hexOffsetVariation));
                    int centerY = y + (_random.Next(-hexOffsetVariation, hexOffsetVariation));

                    int adjustedHexSize = _random.Next(minHexSize, maxHexSize);

                    for (int offsetY = -adjustedHexSize; offsetY <= adjustedHexSize; offsetY++)
                    {
                        for (int offsetX = -adjustedHexSize; offsetX <= adjustedHexSize; offsetX++)
                        {
                            int pixelX = centerX + offsetX;
                            int pixelY = centerY + offsetY;

                            if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                            {
                                double dist = HexagonalDistance(pixelX - centerX, pixelY - centerY, adjustedHexSize);

                                byte color = (byte)(255 * Math.Min(1, maxDistColorFactor * (1 - dist)));
                                heightMap.SetPixel(pixelX, pixelY, global::System.Drawing.Color.FromArgb(color, color, color));
                            }
                        }
                    }
                }
                if ((y / hexHeight) % 2 == 0)
                {
                    // Offset every other row for a hexagonal pattern
                    y += hexHeight / 2;
                }
            }

            return heightMap;
        }

        private static double HexagonalDistance(int x, int y, int hexSize)
        {
            double q2 = (2.0 / 3 * x) / hexSize;
            double r2 = (-1.0 / 3 * x + Math.Sqrt(3) / 3 * y) / hexSize;

            double dist = Math.Max(Math.Abs(q2), Math.Max(Math.Abs(r2), Math.Abs(-q2 - r2)));

            return dist;
        }
    }
}