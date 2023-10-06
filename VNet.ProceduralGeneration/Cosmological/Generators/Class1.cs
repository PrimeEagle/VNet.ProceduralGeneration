﻿using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public class CosmicWebGeneratorX
    {
        private readonly INoiseAlgorithm _noiseAlgorithm;
        private readonly IInterpolationAlgorithm _interpolationAlgorithm;

        public double GravitationalConstant { get; set; } = 1.0;
        public double TimeScalingFactor { get; set; } = 1.0;
        public double ExpansionRate { get; set; } = 70 * 3.15e7 * 2.09e5;
        double initialRadiationStrength = 2.0;  // Arbitrarily chosen value; adjust as needed
        double radiationDecayRate = 0.05;  // Adjust to set how fast radiation diminishes over time
        public int DilationIterations { get; set; } = 1; // Default number of dilation iterations
        public int ErosionIterations { get; set; } = 1;  // Default number of erosion iterations





        public CosmicWebGeneratorX(INoiseAlgorithm noiseAlgorithm, IInterpolationAlgorithm interpolationAlgorithm)
        {
            _noiseAlgorithm = noiseAlgorithm;
            _interpolationAlgorithm = interpolationAlgorithm;
        }

        public double[,,] Generate3DVolume(int x, int y, int z)
        {
            var volume = new double[x, y, z];

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        volume[i, j, k] = _noiseAlgorithm.GenerateSingleSample();
                    }
                }
            }

            return volume;
        }

        public double[,,] ApplyGravityAndExpansion(double[,,] volume, double timeInYears, int range = 1)
        {
            var x = volume.GetLength(0);
            var y = volume.GetLength(1);
            var z = volume.GetLength(2);

            // Create a temporary volume to store the updated values
            var updatedVolume = new double[x, y, z];

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        double gravitationalEffect = 0;

                        // Check points within the specified range for gravitational effects
                        for (var dx = -range; dx <= range; dx++)
                        {
                            for (var dy = -range; dy <= range; dy++)
                            {
                                for (var dz = -range; dz <= range; dz++)
                                {
                                    if (i + dx >= 0 && i + dx < x &&
                                        j + dy >= 0 && j + dy < y &&
                                        k + dz >= 0 && k + dz < z)
                                    {
                                        gravitationalEffect += GravitationalConstant * volume[i + dx, j + dy, k + dz];
                                    }
                                }
                            }
                        }

                        // Multiply by time to simulate gravitational effects over time
                        updatedVolume[i, j, k] = volume[i, j, k] + gravitationalEffect * timeInYears * TimeScalingFactor;
                    }
                }
            }



            double currentRadiationStrength = initialRadiationStrength * Math.Exp(-radiationDecayRate * timeInYears);

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        double radiationEffect = 0;

                        // Similar to gravity, but pushes densities apart
                        for (var dx = -range; dx <= range; dx++)
                        {
                            for (var dy = -range; dy <= range; dy++)
                            {
                                for (var dz = -range; dz <= range; dz++)
                                {
                                    if (i + dx >= 0 && i + dx < x &&
                                        j + dy >= 0 && j + dy < y &&
                                        k + dz >= 0 && k + dz < z)
                                    {
                                        radiationEffect -= currentRadiationStrength * volume[i + dx, j + dy, k + dz];
                                    }
                                }
                            }
                        }

                        // Apply radiation effect after gravitational effect
                        updatedVolume[i, j, k] += radiationEffect * timeInYears;
                    }
                }
            }

            // Update the original volume with the updated values
            Array.Copy(updatedVolume, volume, updatedVolume.Length);

            return ApplyExpansion(volume, timeInYears); // Return the expanded volume.
        }

        private double[,,] ApplyExpansion(double[,,] volume, double timeInYears)
        {
            var x = volume.GetLength(0);
            var y = volume.GetLength(1);
            var z = volume.GetLength(2);

            var scaleFactor = 1.0 + ExpansionRate * timeInYears;

            var expandedVolume = new double[(int)(x * scaleFactor), (int)(y * scaleFactor), (int)(z * scaleFactor)];

            // Convert the 3D volume into a flat array for processing.
            var flatData = new double[x * y * z];
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        flatData[i * y * z + j * z + k] = volume[i, j, k];
                    }
                }
            }

            // Interpolation
            for (var i = 0; i < expandedVolume.GetLength(0); i++)
            {
                for (var j = 0; j < expandedVolume.GetLength(1); j++)
                {
                    for (var k = 0; k < expandedVolume.GetLength(2); k++)
                    {
                        int[] targetIndices = { i, j, k };
                        expandedVolume[i, j, k] = _interpolationAlgorithm.Interpolate(flatData, null /* or some args instance */, new int[] { x, y, z }, targetIndices);
                    }
                }
            }

            // Update the original volume reference to point to the expanded volume
            return expandedVolume;
        }

        public void ApplyMorphologicalOperations(double[,,] volume)
        {
            var x = volume.GetLength(0);
            var y = volume.GetLength(1);
            var z = volume.GetLength(2);

            // Create a 2D image buffer for applying morphological operations
            using (var imageBuffer = new Image<Rgba32>(x, y))
            {
                for (var k = 0; k < z; k++)
                {
                    // Load a 2D slice from the volume into the image buffer
                    for (var i = 0; i < x; i++)
                    {
                        for (var j = 0; j < y; j++)
                        {
                            // Convert volume values (0.0 to 1.0) to grayscale image values (0 to 255)
                            byte value = (byte)(volume[i, j, k] * 255);
                            imageBuffer[i, j] = new Rgba32(value, value, value);
                        }
                    }

                    // Apply dilation and erosion operations with configurable iterations
                    // Apply dilation and erosion operations with configurable iterations
                    for (var d = 0; d < DilationIterations; d++)
                    {
                        imageBuffer.Mutate(x => x.Dilate());
                    }

                    for (var e = 0; e < ErosionIterations; e++)
                    {
                        imageBuffer.Mutate(x => x.Erode());
                    }


                    // Update the 2D slice back into the volume
                    for (var i = 0; i < x; i++)
                    {
                        for (var j = 0; j < y; j++)
                        {
                            // Convert the grayscale image value back to the volume range (0.0 to 1.0)
                            volume[i, j, k] = imageBuffer[i, j].R / 255.0;
                        }
                    }
                }
            }
        }
    }
}