using System.Drawing;

namespace VNet.ProceduralGeneration.Heightmap
{
    public class Foam
    {
        private static readonly Random _random = new();

        public static Bitmap GenerateBubbleHeightMap(int width, int height, int numberOfBubbles)
        {
            var heightMap = new Bitmap(width, height);

            var points = new List<global::System.Drawing.PointF>();

            // Scatter random points
            for (var i = 0; i < numberOfBubbles; i++)
            {
                points.Add(new global::System.Drawing.PointF((float)(_random.NextDouble() * width), (float)(_random.NextDouble() * height)));
            }

            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    var minDist = float.MaxValue;
                    var secondMinDist = float.MaxValue;

                    foreach (var point in points)
                    {
                        var dist = Distance(point, new global::System.Drawing.PointF(x, y));
                        if (dist < minDist)
                        {
                            secondMinDist = minDist;
                            minDist = dist;
                        }
                        else if (dist < secondMinDist)
                        {
                            secondMinDist = dist;
                        }
                    }

                    // Calculate color based on difference of distances
                    var difference = secondMinDist - minDist;
                    var colorValue = (byte)(255 * (1 - Math.Min(1, difference * 3))); // The factor 3 can be adjusted
                    heightMap.SetPixel(x, y, global::System.Drawing.Color.FromArgb(colorValue, colorValue, colorValue));
                }
            }

            return heightMap;
        }

        private static float Distance(global::System.Drawing.PointF a, global::System.Drawing.PointF b)
        {
            return (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
    }
}