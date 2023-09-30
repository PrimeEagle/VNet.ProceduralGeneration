using System.Drawing;
using Color = SixLabors.ImageSharp.Color;

namespace VNet.ProceduralGeneration.Heightmap
{
    public class PlasmaCloud
    {
        private static readonly Random _random = new();

        public static Bitmap GeneratePlasmaHeightMap(int size)
        {
            var heightMap = new Bitmap(size, size);
            var detail = (int)Math.Log(size, 2);

            var data = new float[size, size];

            // Initialization step: setting corners
            data[0, 0] = (float)_random.NextDouble();
            data[0, size - 1] = (float)_random.NextDouble();
            data[size - 1, 0] = (float)_random.NextDouble();
            data[size - 1, size - 1] = (float)_random.NextDouble();

            var h = 1.0f;  // roughness factor

            // Diamond-Square steps
            for (var sideLength = size - 1; sideLength >= 2; sideLength /= 2, h /= 2.0f)
            {
                var halfSide = sideLength / 2;

                // Diamond step
                for (var x = 0; x < size - 1; x += sideLength)
                {
                    for (var y = 0; y < size - 1; y += sideLength)
                    {
                        var avg = data[x, y] + data[x + sideLength, y] + data[x, y + sideLength] + data[x + sideLength, y + sideLength];
                        avg /= 4.0f;

                        data[x + halfSide, y + halfSide] = avg + (float)(_random.NextDouble() * 2 * h) - h;
                    }
                }

                // Square step
                for (var x = 0; x < size; x += halfSide)
                {
                    for (var y = (x + halfSide) % sideLength; y < size; y += sideLength)
                    {
                        var avg = data[(x - halfSide + size) % size, y] + data[(x + halfSide) % size, y] + data[x, (y + halfSide) % size] + data[x, (y - halfSide + size) % size];
                        avg /= 4.0f;

                        data[x, y] = avg + (float)(_random.NextDouble() * 2 * h) - h;

                        // Handle wraparound
                        if (x == 0) data[size - 1, y] = avg;
                        if (y == 0) data[x, size - 1] = avg;
                    }
                }
            }

            // Normalize and draw the heightmap
            float max = float.MinValue, min = float.MaxValue;
            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    if (data[x, y] > max) max = data[x, y];
                    if (data[x, y] < min) min = data[x, y];
                }
            }
            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    var colorValue = (int)(255 * (data[x, y] - min) / (max - min));
                    heightMap.SetPixel(x, y, global::System.Drawing.Color.FromArgb(colorValue, colorValue, colorValue));
                }
            }

            return heightMap;
        }
    }
}