using System.Drawing;


namespace VNet.ProceduralGeneration.Heightmap
{
    public class Honeycomb
    {
        private static readonly Random _random = new();

        public static Bitmap GenerateHeightMap(
            int width,
            int height,
            int minHexSize,
            int maxHexSize,
            int hexOffsetVariation,
            double maxDistColorFactor)
        {
            var heightMap = new Bitmap(width, height);
            var hexHeight = (int)(Math.Sqrt(3) * minHexSize);

            for (var y = 0; y < height; y += hexHeight)
            {
                for (var x = 0; x < width; x += (int)Math.Round(maxHexSize * 1.5))
                {
                    var centerX = x + (_random.Next(-hexOffsetVariation, hexOffsetVariation));
                    var centerY = y + (_random.Next(-hexOffsetVariation, hexOffsetVariation));

                    var adjustedHexSize = _random.Next(minHexSize, maxHexSize);

                    for (var offsetY = -adjustedHexSize; offsetY <= adjustedHexSize; offsetY++)
                    {
                        for (var offsetX = -adjustedHexSize; offsetX <= adjustedHexSize; offsetX++)
                        {
                            var pixelX = centerX + offsetX;
                            var pixelY = centerY + offsetY;

                            if (pixelX >= 0 && pixelX < width && pixelY >= 0 && pixelY < height)
                            {
                                var dist = HexagonalDistance(pixelX - centerX, pixelY - centerY, adjustedHexSize);

                                var color = (byte)(255 * Math.Min(1, maxDistColorFactor * (1 - dist)));
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
            var q2 = (2.0 / 3 * x) / hexSize;
            var r2 = (-1.0 / 3 * x + Math.Sqrt(3) / 3 * y) / hexSize;

            var dist = Math.Max(Math.Abs(q2), Math.Max(Math.Abs(r2), Math.Abs(-q2 - r2)));

            return dist;
        }
    }
}