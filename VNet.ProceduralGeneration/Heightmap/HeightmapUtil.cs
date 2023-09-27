using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological
{
    public static class HeightmapUtil
    {
        public static Image<Rgba32> LoadImage(string imagePath)
        {
            return Image.Load<Rgba32>(imagePath);
        }

        public static Image<Rgba32> GaussianBlur(Image<Rgba32> image, float sigma = 5)
        {
            var blurredImage = image.Clone(ctx => ctx.GaussianBlur(sigma));
            return blurredImage;
        }

        public static float[,] ImageToHeightmap(Image<Rgba32> image)
        {
            var heightmap = new float[image.Width, image.Height];

            for (var y = 0; y < image.Height; y++)
            {
                for (var x = 0; x < image.Width; x++)
                {
                    var pixel = image[x, y];
                    var grayscaleValue = (pixel.R + pixel.G + pixel.B) / 3f / 255f;
                    heightmap[x, y] = grayscaleValue;
                }
            }

            return heightmap;
        }

        public static float[,,] ExtrudeHeightmapToVolumeMap(float[,] heightMap, int maxExtrusionDepth)
        {
            var width = heightMap.GetLength(0);
            var height = heightMap.GetLength(1);

            var volumeMap = new float[width, height, maxExtrusionDepth];

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    for (var z = 0; z < maxExtrusionDepth; z++)
                    {
                        volumeMap[x, y, z] = 0;
                    }
                }
            }

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    var extrusionDepth = (int)(heightMap[x, y] * maxExtrusionDepth);
                    for (var z = 0; z < extrusionDepth; z++)
                    {
                        volumeMap[x, y, z] = 1;
                    }
                }
            }

            return volumeMap;
        }

        public static Vector3[,,] VolumeMapToGradientMap(float[,,] volumeMap)
        {
            var width = volumeMap.GetLength(0);
            var height = volumeMap.GetLength(1);
            var depth = volumeMap.GetLength(2);

            var gradientMap = new Vector3[width, height, depth];

            for (var x = 0; x < width; x++)
            {
                for (var y = 0; y < height; y++)
                {
                    for (var z = 0; z < depth; z++)
                    {
                        var dx = (x < width - 1) ? (volumeMap[x + 1, y, z] - volumeMap[x, y, z]) : 0;
                        var dy = (y < height - 1) ? (volumeMap[x, y + 1, z] - volumeMap[x, y, z]) : 0;
                        var dz = (z < depth - 1) ? (volumeMap[x, y, z + 1] - volumeMap[x, y, z]) : 0;

                        gradientMap[x, y, z] = new Vector3(dx, dy, dz);
                    }
                }
            }

            return gradientMap;
        }
    }
}