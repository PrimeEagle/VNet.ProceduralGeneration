using System.Drawing;
using Color = SixLabors.ImageSharp.Color;
using PointF = SixLabors.ImageSharp.PointF;

namespace VNet.ProceduralGeneration.Heightmap
{
    public class Web
    {
        private static Random _random = new Random();

        public static Bitmap GenerateNetHeightMap(int width, int height, int numberOfNodes)
        {
            Bitmap heightMap = new Bitmap(width, height);

            List<global::System.Drawing.PointF> nodes = new List<global::System.Drawing.PointF>();

            // Scatter random points
            for (int i = 0; i < numberOfNodes; i++)
            {
                nodes.Add(new global::System.Drawing.PointF((float)(_random.NextDouble() * width), (float)(_random.NextDouble() * height)));
            }

            List<Tuple<global::System.Drawing.PointF, global::System.Drawing.PointF>> edges = GenerateMinimumSpanningTree(nodes);

            // Draw edges
            foreach (var edge in edges)
            {
                DrawLine(heightMap, edge.Item1, edge.Item2, global::System.Drawing.Color.White);
            }

            // Optionally: Apply a Gaussian blur or other filters for a more cosmic appearance

            return heightMap;
        }

        private static List<Tuple<global::System.Drawing.PointF, global::System.Drawing.PointF>> GenerateMinimumSpanningTree(List<global::System.Drawing.PointF> nodes)
        {
            var edges = new List<Tuple<global::System.Drawing.PointF, global::System.Drawing.PointF>>();
            while (nodes.Any())
            {
                var node = nodes.First();
                nodes.Remove(node);

                global::System.Drawing.PointF? closestNeighbor = null;
                float minDistance = float.MaxValue;

                foreach (var neighbor in nodes)
                {
                    float dist = Distance(node, neighbor);
                    if (dist < minDistance)
                    {
                        closestNeighbor = neighbor;
                        minDistance = dist;
                    }
                }

                if (closestNeighbor.HasValue)
                {
                    edges.Add(new Tuple<global::System.Drawing.PointF, global::System.Drawing.PointF>(node, closestNeighbor.Value));
                }
            }

            return edges;
        }

        private static float Distance(global::System.Drawing.PointF a, global::System.Drawing.PointF b)
        {
            return (float)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        private static void DrawLine(Bitmap img, global::System.Drawing.PointF start, global::System.Drawing.PointF end, global::System.Drawing.Color color)
        {
            using (Graphics g = Graphics.FromImage(img))
            {
                g.DrawLine(new Pen(color), start, end);
            }
        }
    }
}