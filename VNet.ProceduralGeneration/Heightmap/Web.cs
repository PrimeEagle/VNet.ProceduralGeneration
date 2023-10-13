using System.Drawing;

namespace VNet.ProceduralGeneration.Heightmap;

public class Web
{
    private static readonly Random _random = new();

    public static Bitmap GenerateNetHeightMap(int width, int height, int numberOfNodes)
    {
        var heightMap = new Bitmap(width, height);

        var nodes = new List<PointF>();

        // Scatter random points
        for (var i = 0; i < numberOfNodes; i++) nodes.Add(new PointF((float) (_random.NextDouble() * width), (float) (_random.NextDouble() * height)));

        var edges = GenerateMinimumSpanningTree(nodes);

        // Draw edges
        foreach (var edge in edges) DrawLine(heightMap, edge.Item1, edge.Item2, Color.White);

        // Optionally: Apply a Gaussian blur or other filters for a more cosmic appearance

        return heightMap;
    }

    private static List<Tuple<PointF, PointF>> GenerateMinimumSpanningTree(List<PointF> nodes)
    {
        var edges = new List<Tuple<PointF, PointF>>();
        while (nodes.Any())
        {
            var node = nodes.First();
            nodes.Remove(node);

            PointF? closestNeighbor = null;
            var minDistance = float.MaxValue;

            foreach (var neighbor in nodes)
            {
                var dist = Distance(node, neighbor);
                if (dist < minDistance)
                {
                    closestNeighbor = neighbor;
                    minDistance = dist;
                }
            }

            if (closestNeighbor.HasValue) edges.Add(new Tuple<PointF, PointF>(node, closestNeighbor.Value));
        }

        return edges;
    }

    private static float Distance(PointF a, PointF b)
    {
        return (float) Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
    }

    private static void DrawLine(Bitmap img, PointF start, PointF end, Color color)
    {
        using (var g = Graphics.FromImage(img))
        {
            g.DrawLine(new Pen(color), start, end);
        }
    }
}