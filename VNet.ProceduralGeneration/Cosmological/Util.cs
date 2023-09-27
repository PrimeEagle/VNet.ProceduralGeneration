using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public class Util
    {
        public Image<Rgba32> LoadImage(string imagePath)
        {
            return Image.Load<Rgba32>(imagePath);
        }

        public Image<Rgba32> ApplyGaussianBlur(Image<Rgba32> image, float sigma = 5)
        {
            // Clone the image to keep original intact
            var blurredImage = image.Clone(ctx => ctx.GaussianBlur(sigma));
            return blurredImage;
        }

        public float[,] ConvertImageToHeightmap(Image<Rgba32> image)
        {
            float[,] heightmap = new float[image.Width, image.Height];

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Rgba32 pixel = image[x, y];
                    float grayscaleValue = (pixel.R + pixel.G + pixel.B) / 3f / 255f; // Normalize to [0, 1]
                    heightmap[x, y] = grayscaleValue;
                }
            }

            return heightmap;
        }

        public float[,,] ExtrudeTo3D(float[,] heightMap, int maxExtrusionDepth)
        {
            int width = heightMap.GetLength(0);
            int height = heightMap.GetLength(1);

            float[,,] volumeMap = new float[width, height, maxExtrusionDepth];

            // Initialize the volumeMap to zeros
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int z = 0; z < maxExtrusionDepth; z++)
                    {
                        volumeMap[x, y, z] = 0;
                    }
                }
            }

            // Process the height map and perform extrusion
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int extrusionDepth = (int)(heightMap[x, y] * maxExtrusionDepth);
                    for (int z = 0; z < extrusionDepth; z++)
                    {
                        volumeMap[x, y, z] = 1;  // Set volumeMap value to 1, indicating extruded space
                    }
                }
            }

            return volumeMap;
        }

        public static Vector3[,,] ComputeGradientMap(float[,,] volumeMap)
        {
            int width = volumeMap.GetLength(0);
            int height = volumeMap.GetLength(1);
            int depth = volumeMap.GetLength(2);

            Vector3[,,] gradientMap = new Vector3[width, height, depth];

            // Iterate over the entire volume.
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int z = 0; z < depth; z++)
                    {
                        float dx = (x < width - 1) ? (volumeMap[x + 1, y, z] - volumeMap[x, y, z]) : 0;
                        float dy = (y < height - 1) ? (volumeMap[x, y + 1, z] - volumeMap[x, y, z]) : 0;
                        float dz = (z < depth - 1) ? (volumeMap[x, y, z + 1] - volumeMap[x, y, z]) : 0;

                        gradientMap[x, y, z] = new Vector3(dx, dy, dz);
                    }
                }
            }

            return gradientMap;
        }

    }
}