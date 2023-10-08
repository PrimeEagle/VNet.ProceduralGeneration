using System.Drawing;
using System.Drawing.Imaging;
using MathNet.Numerics.LinearAlgebra;
using VNet.ImageProcessing;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberCanBeMadeStatic.Local
#pragma warning disable CA1822
#pragma warning disable CA1416

namespace VNet.ProceduralGeneration.Cosmological.Generators
{
    public class CosmicWebGeneratorX
    {
        private readonly INoiseAlgorithm _noiseAlgorithm;
        private readonly IInterpolationAlgorithm _interpolationAlgorithm;

        public double GravitationalConstant { get; set; } = 1.0;
        public double TimeScalingFactor { get; set; } = 1.0;
        public double ExpansionRate { get; set; } = 70 * 3.15e7 * 2.09e5;
        double initialRadiationStrength = 2.0; // Arbitrarily chosen value; adjust as needed
        double radiationDecayRate = 0.05; // Adjust to set how fast radiation diminishes over time
        public double BaryonicMatterPercentage { get; set; } = 4.6; // Adjust as per cosmological data
        public double DarkMatterPercentage { get; set; } = 26.8; // Adjust as per cosmological data
        public double DarkEnergyPercentage { get; set; } = 68.6; // Adjust as per cosmological data
        private double _darkEnergyEffect; // Represents the effect of dark energy on the expansion
        private double[,,] _baryonicVolume;
        private double[,,] _darkMatterVolume;
        private double[,,] _hydrogenVolume;
        private double[,,] _heliumVolume;
        private double[,,] _metalVolume;

        public double BaryonicFeedbackThreshold { get; set; } = 1.2; // Arbitrarily set, adjust as needed
        public double BaryonicFeedbackStrength { get; set; } = 0.1; // Represents how much density is reduced due to feedback
        public double BaryonicFeedbackSpread { get; set; } = 0.5; // Represents the proportion of the feedback density that gets spread to neighbors
        private double[,,] _temperatureVolume;
        public double HeatingRate { get; set; } = 0.1; // Arbitrarily set, adjust as needed
        public double CoolingRate { get; set; } = 0.01; // Arbitrarily set, adjust as needed
        private double baseTemperature = 2.7;  // Base temperature, e.g., of CMB in Kelvin
        private const double temperatureFluctuationRange = 0.05; // Adjust as needed; represents the range of temperature variation around the base

        private readonly INoiseAlgorithm _temperatureNoiseAlgorithm;
        public double BaseCoolingRate { get; set; } = 0.01; // Base value
        public double BaseHeatingRate { get; set; } = 0.1; // Base value
        public double CoolingRateDensityFactor { get; set; } = 0.05; // Adjusts the influence of density on cooling rate
        public double HeatingRateDensityFactor { get; set; } = 0.02; // Adjusts the influence of density on heating rate
        public double CollisionalCoolingFactor { get; set; } = 0.02; // Arbitrarily set, adjust as needed
        public double CollisionalHeatingFactor { get; set; } = 0.01; // Arbitrarily set, adjust as needed
        public double StarFormationThreshold { get; set; } = 1.5; // Arbitrary threshold
        public double StarFormationRate { get; set; } = 0.05; // Fraction of gas converted to stars
        public double MergingThreshold { get; set; } = 2.0; // This is an arbitrary value; adjust as needed
        public int MergingRadius { get; set; } = 2; // Cells around a high-density point where mass will be spread
        public double GalacticFeedbackThreshold { get; set; } = 2.5; // Arbitrary density threshold at which feedback is triggered
        public double GalacticFeedbackEnergy { get; set; } = 1.0; // Arbitrary energy value to represent feedback strength
        public double DensityThreshold { get; set; } = 0.2;  // Example value, adjust as needed
        public double StructureThreshold { get; set; } = 0.5;  // Example value, adjust as needed









        public CosmicWebGeneratorX(INoiseAlgorithm noiseAlgorithm, IInterpolationAlgorithm interpolationAlgorithm)
        {
            noiseAlgorithm = noiseAlgorithm;
            _temperatureNoiseAlgorithm = _temperatureNoiseAlgorithm;
            _interpolationAlgorithm = interpolationAlgorithm;
            _darkEnergyEffect = Math.Pow(1 + DarkEnergyPercentage / 100.0, 0.5) - 1; // This is a simplified representation. In reality, the effect of dark energy might be derived from more sophisticated models.
        }

        public void RunSimulation(int x, int y, int z, double totalSimulationTime, double timeStep)
        {
            Generate3DVolumes(x, y, z);

            double currentTime = 0;

            while (currentTime < totalSimulationTime)
            {
                ApplyGravity(timeStep);
                ApplyRadiation(timeStep);
                ApplyBaryonicFeedback(timeStep);
                ApplyHeatingAndCooling(timeStep);
                ApplyInteractions(timeStep);
                ApplyMerging();
                ApplyGalacticFeedback(timeStep);
                ApplyStarFormationAndChemicalEvolution(timeStep);
                ApplyExpansion(timeStep);

                currentTime += timeStep;
            }

            var smoothedVolume = ApplyGaussianSmoothing(volume, sigma);  // Sigma is your chosen smoothing scale
            IdentifyStructures(smoothedVolume);  // This should modify the smoothedVolume or another volume to represent the identified structures

            // 2. Label and Extract
            var labels = LabelConnectedComponents(smoothedVolume, StructureThreshold); // This will give you a labeled volume
            var extractedRegions = ExtractLabeledRegions(labels);
        }

        public void Generate3DVolumes(int x, int y, int z)
        {
            _baryonicVolume = new double[x, y, z];
            _darkMatterVolume = new double[x, y, z];
            _temperatureVolume = new double[x, y, z];

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        var totalNoise = _noiseAlgorithm.GenerateSingleSample();

                        // Assign proportional densities based on the given percentages.
                        // Assuming totalNoise generates a value between 0 and 1,
                        // the baryonic and dark matter percentages help distribute this noise value 
                        // proportionally between the two volumes.
                        _baryonicVolume[i, j, k] = totalNoise * BaryonicMatterPercentage / 100.0;
                        _darkMatterVolume[i, j, k] = totalNoise * DarkMatterPercentage / 100.0;
                        // Create temperature fluctuations based on noise
                        var temperatureNoise = _temperatureNoiseAlgorithm.GenerateSingleSample(); // Assumed to be in range [-1, 1]
                        var temperatureFluctuation = temperatureNoise * temperatureFluctuationRange;

                        _temperatureVolume[i, j, k] = baseTemperature + temperatureFluctuation;

                        var totalBaryonicDensity = _baryonicVolume[i, j, k];
                        _hydrogenVolume[i, j, k] = 0.75 * totalBaryonicDensity;
                        _heliumVolume[i, j, k] = 0.25 * totalBaryonicDensity;
                        _metalVolume[i, j, k] = 0.0; // Initially no metals

                    }
                }
            }
        }

        public void ApplyGalacticFeedback(double timeInYears)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        // Feedback is triggered in high-density regions (e.g., galactic centers)
                        if (!(_baryonicVolume[i, j, k] > GalacticFeedbackThreshold)) continue;
                        // Reduce local density due to feedback
                        _baryonicVolume[i, j, k] -= GalacticFeedbackEnergy * timeInYears;

                        // Increase local temperature due to energy injection
                        _temperatureVolume[i, j, k] += GalacticFeedbackEnergy * timeInYears;

                        // Distribute feedback energy to nearby cells, simulating the outward push of feedback
                        for (var dx = -1; dx <= 1; dx++)
                        {
                            for (var dy = -1; dy <= 1; dy++)
                            {
                                for (var dz = -1; dz <= 1; dz++)
                                {
                                    if (i + dx < 0 || i + dx >= x ||
                                        j + dy < 0 || j + dy >= y ||
                                        k + dz < 0 || k + dz >= z) continue;
                                    _baryonicVolume[i + dx, j + dy, k + dz] -= GalacticFeedbackEnergy * timeInYears / 3; // distributing some energy to neighbors
                                    _temperatureVolume[i + dx, j + dy, k + dz] += GalacticFeedbackEnergy * timeInYears / 3; // raising temperature in neighboring cells
                                }
                            }
                        }
                    }
                }
            }
        }


        public void ApplyStarFormationAndChemicalEvolution(double timeInYears)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        if (!(_baryonicVolume[i, j, k] > StarFormationThreshold) || !(_temperatureVolume[i, j, k] < 10)) continue; // Arbitrary temperature threshold
                        var starsFormed = StarFormationRate * _baryonicVolume[i, j, k] * timeInYears;
                        _baryonicVolume[i, j, k] -= starsFormed;

                        // Convert a portion of the formed stars into metals
                        _metalVolume[i, j, k] += 0.02 * starsFormed; // Assuming 2% of star mass is converted to metals, adjust as needed
                        _hydrogenVolume[i, j, k] -= 0.98 * starsFormed; // Remaining 98% remains as hydrogen
                    }
                }
            }
        }

        public void ApplyMerging()
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            var changeInMass = new double[x, y, z]; // To track the change in mass for each cell

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        if (!(_baryonicVolume[i, j, k] > MergingThreshold)) continue;
                        var excessMass = _baryonicVolume[i, j, k] - MergingThreshold;
                        changeInMass[i, j, k] -= excessMass; // Remove excess mass from the current cell

                        // Distribute the excess mass among neighboring cells
                        for (var dx = -MergingRadius; dx <= MergingRadius; dx++)
                        {
                            for (var dy = -MergingRadius; dy <= MergingRadius; dy++)
                            {
                                for (var dz = -MergingRadius; dz <= MergingRadius; dz++)
                                {
                                    if (i + dx >= 0 && i + dx < x &&
                                        j + dy >= 0 && j + dy < y &&
                                        k + dz >= 0 && k + dz < z)
                                    {
                                        changeInMass[i + dx, j + dy, k + dz] += excessMass / (3 * MergingRadius * MergingRadius); // Uniform distribution
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // Apply the changes to the main volume
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        _baryonicVolume[i, j, k] += changeInMass[i, j, k];
                    }
                }
            }
        }

        public void ApplyInteractions(double timeInYears)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        // Star formation: If density is high and temperature is low
                        if (_baryonicVolume[i, j, k] > StarFormationThreshold && _temperatureVolume[i, j, k] < 10) // Arbitrary temperature threshold
                        {
                            var starsFormed = StarFormationRate * _baryonicVolume[i, j, k] * timeInYears;
                            _baryonicVolume[i, j, k] -= starsFormed;
                        }

                        // Shock heating due to collisions (simplified)
                        // Detect significant gradients in density (e.g., collisions)
                        double densityGradient = 0; // Calculate using neighboring cells; left as an exercise
                        if (densityGradient > 0.5) // Arbitrary threshold
                        {
                            _temperatureVolume[i, j, k] += 10; // Increase temperature due to shock
                        }
                    }
                }
            }
        }

        public void ApplyGravity(double timeInYears, int range = 1)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            var updatedBaryonicVolume = new double[x, y, z];
            var updatedDarkMatterVolume = new double[x, y, z];

            // Gravitational effects considering contributions from both volumes
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        double gravitationalEffectBaryonic = 0;
                        double gravitationalEffectDarkMatter = 0;

                        // Calculate gravitational effects based on nearby particles for both volumes
                        for (var dx = -range; dx <= range; dx++)
                        {
                            for (var dy = -range; dy <= range; dy++)
                            {
                                for (var dz = -range; dz <= range; dz++)
                                {
                                    // Ensure we're within the volume's boundaries
                                    if (i + dx < 0 || i + dx >= x ||
                                        j + dy < 0 || j + dy >= y ||
                                        k + dz < 0 || k + dz >= z) continue;
                                    gravitationalEffectBaryonic += GravitationalConstant * _baryonicVolume[i + dx, j + dy, k + dz];
                                    gravitationalEffectDarkMatter += GravitationalConstant * _darkMatterVolume[i + dx, j + dy, k + dz];
                                }
                            }
                        }

                        updatedBaryonicVolume[i, j, k] = _baryonicVolume[i, j, k] + gravitationalEffectBaryonic * timeInYears * TimeScalingFactor;
                        updatedDarkMatterVolume[i, j, k] = _darkMatterVolume[i, j, k] + gravitationalEffectDarkMatter * timeInYears * TimeScalingFactor;
                    }
                }
            }

            // Copy updated values back to the original volumes
            Array.Copy(updatedBaryonicVolume, _baryonicVolume, updatedBaryonicVolume.Length);
            Array.Copy(updatedDarkMatterVolume, _darkMatterVolume, updatedDarkMatterVolume.Length);
        }

        public void ApplyRadiation(double timeInYears, int range = 1)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            var currentRadiationStrength = initialRadiationStrength * Math.Exp(-radiationDecayRate * timeInYears);

            // Only applying radiation effects to the baryonic volume
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        double radiationEffect = 0;

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
                                        radiationEffect -= currentRadiationStrength * _baryonicVolume[i + dx, j + dy, k + dz];
                                    }
                                }
                            }
                        }

                        _baryonicVolume[i, j, k] += radiationEffect * timeInYears;
                    }
                }
            }
        }

        public void ApplyExpansion(double timeInYears)
        {
            // The effect of dark energy accelerates the expansion of the universe
            var expansionFactor = 1.0 + (ExpansionRate + _darkEnergyEffect) * timeInYears;

            // Interpolate both volumes using the expanded factor
            _baryonicVolume = InterpolateVolume(_baryonicVolume, expansionFactor);
            _darkMatterVolume = InterpolateVolume(_darkMatterVolume, expansionFactor);
        }

        public void ApplyBaryonicFeedback(double timeInYears)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            var feedbackEffects = new double[x, y, z]; // Store the effects here first to prevent double counting

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        if (!(_baryonicVolume[i, j, k] > BaryonicFeedbackThreshold)) continue;
                        var feedback = BaryonicFeedbackStrength * timeInYears;
                        _baryonicVolume[i, j, k] -= feedback;
                        feedbackEffects[i, j, k] = feedback * BaryonicFeedbackSpread; // Portion to spread
                        _temperatureVolume[i, j, k] += HeatingRate * timeInYears;
                    }
                }
            }

            // Spread the feedback effects
            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        if (!(feedbackEffects[i, j, k] > 0)) continue;
                        // Propagate the feedback to neighboring cells
                        for (var dx = -1; dx <= 1; dx++)
                        {
                            for (var dy = -1; dy <= 1; dy++)
                            {
                                for (var dz = -1; dz <= 1; dz++)
                                {
                                    if (i + dx >= 0 && i + dx < x &&
                                        j + dy >= 0 && j + dy < y &&
                                        k + dz >= 0 && k + dz < z &&
                                        !(dx == 0 && dy == 0 && dz == 0)) // Exclude the central cell
                                    {
                                        _baryonicVolume[i + dx, j + dy, k + dz] += feedbackEffects[i, j, k] / 26.0; // Evenly distribute to 26 neighboring cells
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        public void ApplyHeatingAndCooling(double timeInYears)
        {
            var x = _baryonicVolume.GetLength(0);
            var y = _baryonicVolume.GetLength(1);
            var z = _baryonicVolume.GetLength(2);

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        var localDensity = _baryonicVolume[i, j, k];

                        // Calculate density-dependent cooling and heating rates
                        var effectiveCoolingRate = BaseCoolingRate * (1 + CoolingRateDensityFactor * localDensity);
                        var effectiveHeatingRate = BaseHeatingRate * (1 - HeatingRateDensityFactor * localDensity);

                        // Collisional effects: scales with density squared
                        effectiveCoolingRate += CollisionalCoolingFactor * localDensity * localDensity;
                        effectiveHeatingRate += CollisionalHeatingFactor * localDensity * localDensity;

                        _temperatureVolume[i, j, k] -= effectiveCoolingRate * timeInYears * _temperatureVolume[i, j, k];
                        _temperatureVolume[i, j, k] += effectiveHeatingRate * timeInYears;
                    }
                }
            }
        }



        private double[,,] InterpolateVolume(double[,,] volume, double scaleFactor)
        {
            var x = volume.GetLength(0);
            var y = volume.GetLength(1);
            var z = volume.GetLength(2);

            var expandedX = (int)(x * scaleFactor);
            var expandedY = (int)(y * scaleFactor);
            var expandedZ = (int)(z * scaleFactor);

            var expandedVolume = new double[expandedX, expandedY, expandedZ];

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
            for (var i = 0; i < expandedX; i++)
            {
                for (var j = 0; j < expandedY; j++)
                {
                    for (var k = 0; k < expandedZ; k++)
                    {
                        // Convert expanded indices to original volume's scale
                        int[] targetIndices =
                        {
                            (int)(i / scaleFactor),
                            (int)(j / scaleFactor),
                            (int)(k / scaleFactor)
                        };

                        // Interpolate to get the value at the current position in the expanded volume
                        expandedVolume[i, j, k] = _interpolationAlgorithm.Interpolate(flatData, null /* or some args instance */, new int[] { x, y, z }, targetIndices);
                    }
                }
            }

            return expandedVolume;
        }

        public void IdentifyStructures(double[,,] smoothedVolume)
        {
            var x = smoothedVolume.GetLength(0);
            var y = smoothedVolume.GetLength(1);
            var z = smoothedVolume.GetLength(2);

            for (var i = 1; i < x - 1; i++)
            {
                for (var j = 1; j < y - 1; j++)
                {
                    for (var k = 1; k < z - 1; k++)
                    {
                        var density = smoothedVolume[i, j, k];

                        // Check against densityThreshold
                        if (density < DensityThreshold)
                        {
                            // Void
                            continue;
                        }

                        if (density < StructureThreshold)
                        {
                            // Uninteresting region, can skip or label accordingly
                            continue;
                        }

                        var hessian = ComputeHessian(i, j, k, smoothedVolume);
                        var evd = hessian.Evd();
                        var eigenValues = evd.EigenValues;

                        if (eigenValues[0].Real > 0 && eigenValues[1].Real > 0 && eigenValues[2].Real > 0)
                        {
                            // Node
                        }
                        else if (eigenValues[0].Real > 0 && eigenValues[1].Real > 0 && eigenValues[2].Real < 0)
                        {
                            // Filament
                        }
                        else if (eigenValues[0].Real > 0 && eigenValues[1].Real < 0 && eigenValues[2].Real < 0)
                        {
                            // Sheet
                        }
                        else
                        {
                            // Other, or you can classify as void
                        }
                    }
                }
            }
        }
        
        private Matrix<double> ComputeHessian(int i, int j, int k, double[,,] volume)
        {
            var dxx = volume[i + 1, j, k] - 2 * volume[i, j, k] + volume[i - 1, j, k];
            var dyy = volume[i, j + 1, k] - 2 * volume[i, j, k] + volume[i, j - 1, k];
            var dzz = volume[i, j, k + 1] - 2 * volume[i, j, k] + volume[i, j, k - 1];

            var dxy = (volume[i + 1, j + 1, k] - volume[i + 1, j - 1, k]
                                               - volume[i - 1, j + 1, k] + volume[i - 1, j - 1, k]) * 0.25;
            var dxz = (volume[i + 1, j, k + 1] - volume[i + 1, j, k - 1]
                                               - volume[i - 1, j, k + 1] + volume[i - 1, j, k - 1]) * 0.25;
            var dyz = (volume[i, j + 1, k + 1] - volume[i, j + 1, k - 1]
                                               - volume[i, j - 1, k + 1] + volume[i, j - 1, k - 1]) * 0.25;

            var hessian = Matrix<double>.Build.DenseOfArray(new double[,]
            {
                {dxx, dxy, dxz},
                {dxy, dyy, dyz},
                {dxz, dyz, dzz}
            });

            return hessian;
        }

        public int[,,] LabelConnectedComponents(double[,,] structureVolume, double threshold)
        {
            var x = structureVolume.GetLength(0);
            var y = structureVolume.GetLength(1);
            var z = structureVolume.GetLength(2);

            var labels = new int[x, y, z];  // Volume to store labels
            var currentLabel = 1;

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        if (structureVolume[i, j, k] > threshold && labels[i, j, k] == 0)
                        {
                            FloodFill(structureVolume, labels, i, j, k, currentLabel, threshold);
                            currentLabel++;
                        }
                    }
                }
            }

            return labels;
        }

        private void FloodFill(double[,,] structureVolume, int[,,] labels, int x, int y, int z, int label, double threshold)
        {
            var maxX = structureVolume.GetLength(0);
            var maxY = structureVolume.GetLength(1);
            var maxZ = structureVolume.GetLength(2);

            var queue = new Queue<(int x, int y, int z)>();
            queue.Enqueue((x, y, z));

            while (queue.Count > 0)
            {
                var voxel = queue.Dequeue();
                if (voxel.x < 0 || voxel.x >= maxX ||
                    voxel.y < 0 || voxel.y >= maxY ||
                    voxel.z < 0 || voxel.z >= maxZ)
                    continue;

                if (structureVolume[voxel.x, voxel.y, voxel.z] <= threshold || labels[voxel.x, voxel.y, voxel.z] > 0)
                    continue;

                labels[voxel.x, voxel.y, voxel.z] = label;

                queue.Enqueue((voxel.x + 1, voxel.y, voxel.z));
                queue.Enqueue((voxel.x - 1, voxel.y, voxel.z));
                queue.Enqueue((voxel.x, voxel.y + 1, voxel.z));
                queue.Enqueue((voxel.x, voxel.y - 1, voxel.z));
                queue.Enqueue((voxel.x, voxel.y, voxel.z + 1));
                queue.Enqueue((voxel.x, voxel.y, voxel.z - 1));
            }
        }


        public Dictionary<int, List<(int x, int y, int z)>> ExtractLabeledRegions(int[,,] labels)
        {
            var regions = new Dictionary<int, List<(int x, int y, int z)>>();

            for (var i = 0; i < labels.GetLength(0); i++)
            {
                for (var j = 0; j < labels.GetLength(1); j++)
                {
                    for (var k = 0; k < labels.GetLength(2); k++)
                    {
                        var label = labels[i, j, k];
                        if (label > 0)
                        {
                            if (!regions.ContainsKey(label))
                            {
                                regions[label] = new List<(int x, int y, int z)>();
                            }
                            regions[label].Add((i, j, k));
                        }
                    }
                }
            }

            return regions;
        }

        private double GaussianKernel(double distance, double sigma)
        {
            return (1.0 / (Math.Sqrt(2 * Math.PI) * sigma)) * Math.Exp(-0.5 * (distance / sigma) * (distance / sigma));
        }

        private double[,,] ApplyGaussianSmoothing(double[,,] volume, double sigma)
        {
            var x = volume.GetLength(0);
            var y = volume.GetLength(1);
            var z = volume.GetLength(2);
            var smoothedVolume = new double[x, y, z];

            // Define a kernel radius based on sigma.
            var kernelRadius = (int)Math.Ceiling(3 * sigma);

            for (var i = 0; i < x; i++)
            {
                for (var j = 0; j < y; j++)
                {
                    for (var k = 0; k < z; k++)
                    {
                        double sum = 0;
                        double weightSum = 0;

                        for (var dx = -kernelRadius; dx <= kernelRadius; dx++)
                        {
                            for (var dy = -kernelRadius; dy <= kernelRadius; dy++)
                            {
                                for (var dz = -kernelRadius; dz <= kernelRadius; dz++)
                                {
                                    if (i + dx >= 0 && i + dx < x &&
                                        j + dy >= 0 && j + dy < y &&
                                        k + dz >= 0 && k + dz < z)
                                    {
                                        var weight = GaussianKernel(Math.Sqrt(dx * dx + dy * dy + dz * dz), sigma);
                                        sum += weight * volume[i + dx, j + dy, k + dz];
                                        weightSum += weight;
                                    }
                                }
                            }
                        }
                        smoothedVolume[i, j, k] = sum / weightSum;
                    }
                }
            }
            return smoothedVolume;
        }


        //public void IdentifyAndDrawStructures(double[,,] densityMap, byte threshold, string outputImagePath)
        //{
        //    var inputImage = ImageUtil.ConvertDensityMapToBitmap(densityMap);
        //    var grayscaleImage = inputImage.ConvertToGrayscale(0.2125, 0.7154, 0.0721);
        //    var thresholdImage = grayscaleImage.Threshold(threshold);

        //    // Perform image processing to identify cosmic structures
        //    var cosmicStructures = IdentifyCosmicStructures(thresholdImage);

        //    // Create a result image and draw the identified structures on it
        //    var resultImage = new Bitmap(inputImage.Width, inputImage.Height);

        //    using (var graphics = Graphics.FromImage(resultImage))
        //    {
        //        graphics.DrawImage(inputImage, 0, 0); // Copy the original image to the result
        //        DrawStructures(graphics, cosmicStructures);
        //    }

        //    // Save the result image
        //    resultImage.Save(outputImagePath, ImageFormat.Png);
        //}

        //public static List<CosmicStructure> IdentifyCosmicStructures(Bitmap thresholdImage)
        //{
        //    var bmpData = thresholdImage.LockBits(new Rectangle(0, 0, thresholdImage.Width, thresholdImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

        //    var cosmicStructures = new List<CosmicStructure>();
        //    var processedColors = new HashSet<Color>();

        //    unsafe
        //    {
        //        var ptr = (byte*) bmpData.Scan0;

        //        for (var y = 0; y < bmpData.Height; y++)
        //        {
        //            for (var x = 0; x < bmpData.Width; x++)
        //            {
        //                var idx = y * bmpData.Stride + x * 3;
        //                var currentColor = Color.FromArgb(ptr[idx + 2], ptr[idx + 1], ptr[idx]);

        //                if (currentColor == Color.Black || processedColors.Contains(currentColor))
        //                    continue; // skip background and already processed blobs

        //                // Determine the type of cosmic structure based on currentColor
        //                var structureType = DetermineStructureType(currentColor);

        //                if (structureType == StructureType.Unknown) continue;
        //                var cosmicStructure = new CosmicStructure
        //                {
        //                    Type = structureType,
        //                    Area = 0,
        //                    Centroid = new Point(0, 0),
        //                    BoundingBox = new Rectangle(x, y, 1, 1),
        //                    BoundaryPoints = GetBoundaryPoints(thresholdImage, new Point(x, y), currentColor)
        //                };
        //                processedColors.Add(currentColor);

        //                // Further processing if needed, such as area calculation
        //                cosmicStructure.Area = cosmicStructure.BoundaryPoints.Count;

        //                cosmicStructures.Add(cosmicStructure);
        //            }
        //        }
        //    }

        //    thresholdImage.UnlockBits(bmpData);

        //    // Calculate centroids and other properties
        //    foreach (var structure in cosmicStructures)
        //    {
        //        CalculateStructureProperties(structure);
        //    }

        //    return cosmicStructures;
        //}

        //public static void DrawStructures(Graphics graphics, Bitmap structureBitmap, Color structureColor)
        //{
        //    var rect = new Rectangle(0, 0, structureBitmap.Width, structureBitmap.Height);
        //    var bmpData = structureBitmap.LockBits(rect, ImageLockMode.ReadOnly, structureBitmap.PixelFormat);

        //    var bytesPerPixel = Image.GetPixelFormatSize(structureBitmap.PixelFormat) / 8;
        //    var stride = bmpData.Stride;

        //    unsafe
        //    {
        //        var ptr = (byte*) bmpData.Scan0;

        //        using var brush = new SolidBrush(structureColor);
        //        for (var y = 0; y < structureBitmap.Height; y++)
        //        {
        //            for (var x = 0; x < structureBitmap.Width; x++)
        //            {
        //                // Check if the pixel represents the structure (e.g., black)
        //                if (ptr[y * stride + x * bytesPerPixel] == 0)
        //                {
        //                    graphics.FillRectangle(brush, x, y, 1, 1);
        //                }
        //            }
        //        }
        //    }

        //    structureBitmap.UnlockBits(bmpData);
        //}


        //public StructureType DetermineStructureType()
        //{
        //    double AverageDensity;
        //    double Size;
        //    double AspectRatio;
        //    Point Centroid;

        //    // Define a property to store the ID of the connected node
        //    int ConnectedNodeID;

        //    // Check connectivity to nodes
        //    if (structureType == StructureType.Filament)
        //    {
        //        // Implement connectivity logic here
        //        if (IsConnectedToNode()) // Implement the IsConnectedToNode method
        //        {
        //            return StructureType.FilamentConnectedToNode;
        //        }
        //        else
        //        {
        //            return StructureType.Filament;
        //        }
        //    }

        //    // ...
        //}

        //private bool IsConnectedToNode()
        //{
        //    // Calculate distance between the centroid of this filament and centroids of nodes
        //    foreach (var node in ListOfNodes)
        //    {
        //        var distance = CalculateDistance(Centroid, node.Centroid);
        //        if (distance < ThresholdDistance) // Adjust the threshold as needed
        //        {
        //            // This filament is connected to the node
        //            ConnectedNodeID = node.NodeID;
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //// Helper method to calculate the Euclidean distance between two points
        //private double CalculateDistance(Point p1, Point p2)
        //{
        //    double dx = p1.X - p2.X;
        //    double dy = p1.Y - p2.Y;
        //    return Math.Sqrt(dx * dx + dy * dy);
        //}
    }

    //public class CosmicStructure
    //{
    //    public Color Color { get; set; } // Color associated with the structure
    //    public int Area { get; set; } // Area of the structure
    //    public Point Centroid { get; set; } // Centroid (center of mass) of the structure
    //    public Rectangle BoundingBox { get; set; } // Bounding box of the structure
    //    public List<Point> BoundaryPoints { get; set; } // List of boundary points of the structure

    //    public CosmicStructure(Color color)
    //    {
    //        Color = color;
    //        Area = 0;
    //        Centroid = Point.Empty;
    //        BoundingBox = Rectangle.Empty;
    //        BoundaryPoints = new List<Point>();
    //    }
    //}

    //public enum StructureType
    //{
    //    Node,
    //    Filament,
    //    Sheet,
    //    Void,
    //    Other
    //}
}