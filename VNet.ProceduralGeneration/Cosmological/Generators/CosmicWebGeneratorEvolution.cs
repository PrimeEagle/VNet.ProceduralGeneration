using VNet.Mathematics.LinearAlgebra.Matrix;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.Contexts;
using VNet.Scientific.Interpolation;
using VNet.Scientific.Noise;
// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable PossibleLossOfFraction
// ReSharper disable MemberCanBeMadeStatic.Global
#pragma warning disable CA1822
#pragma warning disable IDE0060
#pragma warning disable CS0649


namespace VNet.ProceduralGeneration.Cosmological.Generators;

public partial class CosmicWebGenerator : ContainerGeneratorBase<CosmicWeb, CosmicWebContext>
{
    private readonly INoiseAlgorithm _noiseAlgorithm;
    private readonly IInterpolationAlgorithm _interpolationAlgorithm;
    private readonly INoiseAlgorithm _temperatureNoiseAlgorithm;
    private double[,,] _baryonicVolume;
    private double[,,] _darkMatterVolume;
    private readonly double[,,] _hydrogenVolume;
    private readonly double[,,] _heliumVolume;
    private readonly double[,,] _metalVolume;
    private readonly double[,,] _massArray;
    private readonly double[,,] _velocityXArray;
    private readonly double[,,] _velocityYArray;
    private readonly double[,,] _velocityZArray;
    private readonly double[,,] _tempMassArray;
    private double[,,] _temperatureVolume;
    private double _darkEnergyEffect; // Represents the effect of dark energy on the expansion
    private double _totalEnergy;
    


    public double ExpansionRate { get; set; } = 70 * 3.15e7 * 2.09e5;
    private const double _initialRadiationStrength = 2.0; // Arbitrarily chosen value; adjust as needed
    private const double _radiationDecayRate = 0.05; // Adjust to set how fast radiation diminishes over time
    public double BaryonicMatterPercentage { get; set; } = 4.6; // Adjust as per cosmological data
    public double DarkMatterPercentage { get; set; } = 26.8; // Adjust as per cosmological data
    public double DarkEnergyPercentage { get; set; } = 68.6; // Adjust as per cosmological data
    public double BaryonicFeedbackThreshold { get; set; } = 1.2; // Arbitrarily set, adjust as needed
    public double BaryonicFeedbackStrength { get; set; } = 0.1; // Represents how much density is reduced due to feedback
    public double BaryonicFeedbackSpread { get; set; } = 0.5; // Represents the proportion of the feedback density that gets spread to neighbors
    private const double BaseTemperature = 2.7; // Base temperature, e.g., of CMB in Kelvin
    private const double TemperatureFluctuationRange = 0.05; // Adjust as needed; represents the range of temperature variation around the base
    public double BaseCoolingRate { get; set; } = 0.01; // Base value
    public double BaseHeatingRate { get; set; } = 0.1; // Base value
    public double CoolingRateDensityFactor { get; set; } = 0.05; // Adjusts the influence of density on cooling rate
    public double HeatingRateDensityFactor { get; set; } = 0.02; // Adjusts the influence of density on heating rate
    public double CollisionalCoolingFactor { get; set; } = 0.02; // Arbitrarily set, adjust as needed
    public double CollisionalHeatingFactor { get; set; } = 0.01; // Arbitrarily set, adjust as needed
    public double StarFormationMinimumDensityThreshold { get; set; } = 1.5; // Arbitrary threshold
    public double StarFormationRate { get; set; } = 0.05; // Fraction of gas converted to stars
    public double MergingThreshold { get; set; } = 2.0; // This is an arbitrary value; adjust as needed
    public int MergingRadius { get; set; } = 2; // Cells around a high-density point where mass will be spread
    public double GalacticFeedbackThreshold { get; set; } = 2.5; // Arbitrary density threshold at which feedback is triggered
    public double GalacticFeedbackEnergy { get; set; } = 1.0; // Arbitrary energy value to represent feedback strength
    public double DensityThreshold { get; set; } = 0.2; // Example value, adjust as needed
    public double StructureThreshold { get; set; } = 0.5; // Example value, adjust as needed
    private readonly double _sigma = 0.5;
    private const double initialHydrogenPercentage = 75.0;
    private const double initialHeliumPercentage = 25.0;
    private const double initialMetalPercentage = 0.0;
    private const double starFormationMaximumTemperatureThreshold = 10.0;
    private const double shockHeatingMinimumDensityThreshold = 0.5;
    private const int MapX = 100;
    private const int MapY = 100;
    private const int MapZ = 100;
    private const double totalSimulationTime = 15e9;
    private const double _timeStep = 1;

    private void GenerateCosmicWebByEvolution(CosmicWebContext context, CosmicWeb self)
    {
        _darkEnergyEffect = Math.Pow(1 + DarkEnergyPercentage / 100.0, 0.5) - 1; // This is a simplified representation. In reality, the effect of dark energy might be derived from more sophisticated models.

        InitializeVolumes();

        double currentTime = 0;

        while (currentTime < totalSimulationTime)
        {
            ApplyGravity(currentTime);
            UpdateVelocitiesBasedOnForces(currentTime);
            ApplyRadiation(currentTime);
            ApplyBaryonicFeedback(currentTime);
            ApplyStarFormationAndChemicalEvolution(currentTime);
            ApplyHeatingAndCooling(currentTime);
            ApplyInteractions(currentTime);
            ApplyMerging();
            ApplyGalacticFeedback(currentTime);
            ApplyExpansion(currentTime);
            AdvectMass(currentTime);
            HandleBoundaries();

            currentTime += _timeStep;
        }

        var smoothedVolume = ApplyGaussianSmoothing(_baryonicVolume, _sigma); // Sigma is your chosen smoothing scale
        IdentifyStructures(smoothedVolume); // This should modify the smoothedVolume or another volume to represent the identified structures

        var labels = LabelConnectedComponents(smoothedVolume, StructureThreshold); // This will give you a labeled volume
        var extractedRegions = ExtractLabeledRegions(labels);
    }

    private void InitializeVolumes()
    {
        _baryonicVolume = new double[MapX, MapY, MapZ];
        _darkMatterVolume = new double[MapX, MapY, MapZ];
        _temperatureVolume = new double[MapX, MapY, MapZ];

        RunVolumeFunction((int i, int j, int k) =>
        {
            var totalNoise = _noiseAlgorithm.GenerateSingleSample();

            _baryonicVolume[i, j, k] = totalNoise * BaryonicMatterPercentage / 100.0;
            _darkMatterVolume[i, j, k] = totalNoise * DarkMatterPercentage / 100.0;
            var temperatureNoise = _temperatureNoiseAlgorithm.GenerateSingleSample(); // Assumed to be in range [-1, 1]
            var temperatureFluctuation = temperatureNoise * TemperatureFluctuationRange;
            _temperatureVolume[i, j, k] = BaseTemperature + temperatureFluctuation;
            var totalBaryonicDensity = _baryonicVolume[i, j, k];
            _hydrogenVolume[i, j, k] = initialHydrogenPercentage / 100 * totalBaryonicDensity;
            _heliumVolume[i, j, k] = initialHeliumPercentage / 100 * totalBaryonicDensity;
            _metalVolume[i, j, k] = initialMetalPercentage / 100 * totalBaryonicDensity;
            _massArray[i, j, k] = _baryonicVolume[i, j, k] + _darkMatterVolume[i, j, k];
            _totalEnergy += _temperatureVolume[i, j, k];
        });
    }

    private void RunVolumeFunction(Action<int, int, int> function)
    {
        for (var i = 0; i < MapX; i++)
        {
            for (var j = 0; j < MapY; j++)
            {
                for (var k = 0; k < MapZ; k++)
                {
                    function(i, j, k);
                }
            }
        }
    }

    private void UpdateVelocitiesBasedOnForces(double timeStep)
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            double accelerationX = 0;
            double accelerationY = 0;
            double accelerationZ = 0;

            // Loop over neighboring voxels to compute the gravitational effects
            for (var dx = -1; dx <= 1; dx++)
            {
                for (var dy = -1; dy <= 1; dy++)
                {
                    for (var dz = -1; dz <= 1; dz++)
                    {
                        var ni = i + dx;
                        var nj = j + dy;
                        var nk = k + dz;

                        // Ensure neighbor is within bounds and is not the current voxel itself
                        if (ni < 0 || ni >= MapX || nj < 0 || nj >= MapY || nk < 0 || nk >= MapZ || (dx == 0 && dy == 0 && dz == 0)) continue;
                        var aGravity = AdvancedSettings.PhysicalConstants.G * _massArray[ni, nj, nk];
                        accelerationX += dx == 0 ? 0 : (dx / Math.Abs(dx)) * aGravity;
                        accelerationY += dy == 0 ? 0 : (dy / Math.Abs(dy)) * aGravity;
                        accelerationZ += dz == 0 ? 0 : (dz / Math.Abs(dz)) * aGravity;
                    }
                }
            }

            _velocityXArray[i, j, k] += accelerationX * timeStep;
            _velocityYArray[i, j, k] += accelerationY * timeStep;
            _velocityZArray[i, j, k] += accelerationZ * timeStep;
        });
    }

    private void AdvectMass(double timeStep)
    {
        Array.Copy(_massArray, _tempMassArray, _massArray.Length);

        RunVolumeFunction((int i, int j, int k) =>
        {
            var dx = (int)(_velocityXArray[i, j, k] * timeStep);
            var dy = (int)(_velocityYArray[i, j, k] * timeStep);
            var dz = (int)(_velocityZArray[i, j, k] * timeStep);

            var newX = i + dx;
            var newY = j + dy;
            var newZ = k + dz;

            if (!IsWithinBounds(newX, newY, newZ)) return;
            _tempMassArray[newX, newY, newZ] += _massArray[i, j, k];
            _tempMassArray[i, j, k] -= _massArray[i, j, k];
        });

        Array.Copy(_tempMassArray, _massArray, _massArray.Length);
    }

    private bool IsWithinBounds(int x, int y, int z)
    {
        return x is >= 0 and < MapX &&
               y is >= 0 and < MapY &&
               z is >= 0 and < MapZ;
    }

    private void HandleBoundaries()
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            if (i != 0 && i != MapX - 1 &&
                j != 0 && j != MapY - 1 &&
                k != 0 && k != MapZ - 1) return;

            // Assuming the temperature volume gives the thermal energy per unit mass
            _totalEnergy -= _massArray[i, j, k] * _temperatureVolume[i, j, k];
            _massArray[i, j, k] = 0;
            _temperatureVolume[i, j, k] = 0; // resetting the temperature as well
        });
    }

    private void ApplyGalacticFeedback(double timeInYears)
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            // Feedback is triggered in high-density regions (e.g., galactic centers)
            if (_baryonicVolume[i, j, k] <= GalacticFeedbackThreshold) return;

            // Calculate the energy change due to feedback
            var energyReductionFromDensity = GalacticFeedbackEnergy * timeInYears;
            var energyIncreaseFromTemperature = GalacticFeedbackEnergy * timeInYears;

            // Update the total energy
            _totalEnergy -= energyReductionFromDensity; // reduction in energy due to loss of mass
            _totalEnergy += energyIncreaseFromTemperature; // increase in energy due to temperature increase

            // Apply the feedback effects
            _baryonicVolume[i, j, k] -= energyReductionFromDensity;
            _temperatureVolume[i, j, k] += energyIncreaseFromTemperature;

            // Distribute feedback energy to nearby cells, simulating the outward push of feedback
            for (var dx = -1; dx <= 1; dx++)
            {
                for (var dy = -1; dy <= 1; dy++)
                {
                    for (var dz = -1; dz <= 1; dz++)
                    {
                        if (i + dx < 0 || i + dx >= MapX ||
                            j + dy < 0 || j + dy >= MapY ||
                            k + dz < 0 || k + dz >= MapZ) continue;

                        var localEnergyReduction = GalacticFeedbackEnergy * timeInYears / 3;
                        var localEnergyIncrease = GalacticFeedbackEnergy * timeInYears / 3;

                        _totalEnergy -= localEnergyReduction; // reduction in energy due to loss of mass
                        _totalEnergy += localEnergyIncrease; // increase in energy due to temperature increase

                        _baryonicVolume[i + dx, j + dy, k + dz] -= localEnergyReduction;
                        _temperatureVolume[i + dx, j + dy, k + dz] += localEnergyIncrease;
                    }
                }
            }
        });
    }

    private void ApplyStarFormationAndChemicalEvolution(double timeInYears)
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            if (_baryonicVolume[i, j, k] <= StarFormationMinimumDensityThreshold || _temperatureVolume[i, j, k] >= starFormationMaximumTemperatureThreshold) return; // Arbitrary temperature threshold
            var starsFormed = StarFormationRate * _baryonicVolume[i, j, k] * timeInYears;

            // Update the total energy: We're assuming that the formation of stars maintains the energy (mass-energy equivalence).
            // But if there's a release of energy during star formation, that would need to be accounted for.
            _totalEnergy -= starsFormed;

            // Reduce baryonic matter due to star formation
            _baryonicVolume[i, j, k] -= starsFormed;

            // Convert a portion of the formed stars into metals and update total energy
            var metalFormed = 0.02 * starsFormed; // Assuming 2% of star mass is converted to metals
            _metalVolume[i, j, k] += metalFormed;
            _totalEnergy += metalFormed;

            // Convert the rest into hydrogen and update total energy
            var hydrogenFormed = 0.98 * starsFormed; // Remaining 98% remains as hydrogen
            _hydrogenVolume[i, j, k] -= hydrogenFormed;
            _totalEnergy -= hydrogenFormed;
        });
    }

    private void ApplyMerging()
    {
        var changeInMass = new double[MapX, MapY, MapZ]; // To track the change in mass for each cell

        RunVolumeFunction((int i, int j, int k) =>
        {
            if (_baryonicVolume[i, j, k] <= MergingThreshold) return;

            var excessMass = _baryonicVolume[i, j, k] - MergingThreshold;
            changeInMass[i, j, k] -= excessMass; // Remove excess mass from the current cell

            var countNeighbors = 0; // Count valid neighbors to distribute mass uniformly

            // Count valid neighbors
            for (var dx = -MergingRadius; dx <= MergingRadius; dx++)
            {
                for (var dy = -MergingRadius; dy <= MergingRadius; dy++)
                {
                    for (var dz = -MergingRadius; dz <= MergingRadius; dz++)
                    {
                        if (i + dx >= 0 && i + dx < MapX &&
                            j + dy >= 0 && j + dy < MapY &&
                            k + dz >= 0 && k + dz < MapZ)
                        {
                            countNeighbors++;
                        }
                    }
                }
            }

            // Distribute the excess mass among valid neighboring cells
            for (var dx = -MergingRadius; dx <= MergingRadius; dx++)
            {
                for (var dy = -MergingRadius; dy <= MergingRadius; dy++)
                {
                    for (var dz = -MergingRadius; dz <= MergingRadius; dz++)
                    {
                        if (i + dx >= 0 && i + dx < MapX &&
                            j + dy >= 0 && j + dy < MapY &&
                            k + dz >= 0 && k + dz < MapZ)
                        {
                            changeInMass[i + dx, j + dy, k + dz] += excessMass / countNeighbors;
                        }
                    }
                }
            }
        });

        RunVolumeFunction((int i, int j, int k) => { _baryonicVolume[i, j, k] = Math.Max(0, _baryonicVolume[i, j, k] + changeInMass[i, j, k]); });
    }

    private void ApplyInteractions(double timeInYears)
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            // Star formation: If density is high and temperature is low
            if (_baryonicVolume[i, j, k] > StarFormationMinimumDensityThreshold && _temperatureVolume[i, j, k] < starFormationMaximumTemperatureThreshold) // Arbitrary temperature threshold
            {
                var starsFormed = StarFormationRate * _baryonicVolume[i, j, k] * timeInYears;
                _baryonicVolume[i, j, k] -= starsFormed;
            }

            // Shock heating due to collisions (simplified)
            // Detect significant gradients in density (e.g., collisions)
            var densityGradient = CalculateDensityGradient(i, j, k);

            if (densityGradient > shockHeatingMinimumDensityThreshold) // Arbitrary threshold
            {
                _temperatureVolume[i, j, k] += 10; // Increase temperature due to shock
            }
        });
    }

    private double CalculateDensityGradient(int i, int j, int k)
    {
        double gradient = 0;

        for (var dx = -1; dx <= 1; dx++)
        {
            for (var dy = -1; dy <= 1; dy++)
            {
                for (var dz = -1; dz <= 1; dz++)
                {
                    if (i + dx >= 0 && i + dx < MapX &&
                        j + dy >= 0 && j + dy < MapY &&
                        k + dz >= 0 && k + dz < MapZ)
                    {
                        gradient += Math.Abs(_baryonicVolume[i + dx, j + dy, k + dz] - _baryonicVolume[i, j, k]);
                    }
                }
            }
        }

        // Normalize by number of neighbors (for a 3x3x3 cube it's 27 cells minus the center cell)
        gradient /= 26.0;
        return gradient;
    }

    private void ApplyGravity(double timeInYears, int range = 1)
    {

        var updatedBaryonicVolume = new double[MapX, MapY, MapZ];
        var updatedDarkMatterVolume = new double[MapX, MapY, MapZ];

        RunVolumeFunction((int i, int j, int k) =>
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
                        if (i + dx < 0 || i + dx >= MapX ||
                            j + dy < 0 || j + dy >= MapY ||
                            k + dz < 0 || k + dz >= MapZ) continue;

                        double distanceSquared = dx * dx + dy * dy + dz * dz;
                        if (distanceSquared == 0) continue; // prevent self-interaction

                        // Consider gravitational effects from both baryonic and dark matter
                        gravitationalEffectBaryonic += AdvancedSettings.PhysicalConstants.G * (_baryonicVolume[i + dx, j + dy, k + dz] + _darkMatterVolume[i + dx, j + dy, k + dz]) / distanceSquared;
                        gravitationalEffectDarkMatter += AdvancedSettings.PhysicalConstants.G * (_baryonicVolume[i + dx, j + dy, k + dz] + _darkMatterVolume[i + dx, j + dy, k + dz]) / distanceSquared;
                    }
                }
            }

            updatedBaryonicVolume[i, j, k] = _baryonicVolume[i, j, k] + gravitationalEffectBaryonic * timeInYears;
            updatedDarkMatterVolume[i, j, k] = _darkMatterVolume[i, j, k] + gravitationalEffectDarkMatter * timeInYears;
        });

        // Copy updated values back to the original volumes
        Array.Copy(updatedBaryonicVolume, _baryonicVolume, updatedBaryonicVolume.Length);
        Array.Copy(updatedDarkMatterVolume, _darkMatterVolume, updatedDarkMatterVolume.Length);
    }

    private void ApplyRadiation(double timeInYears, int range = 1)
    {
        var currentRadiationStrength = _initialRadiationStrength * Math.Exp(-_radiationDecayRate * timeInYears);

        RunVolumeFunction((int i, int j, int k) =>
        {
            double radiationEffect = 0;

            for (var dx = -range; dx <= range; dx++)
            {
                for (var dy = -range; dy <= range; dy++)
                {
                    for (var dz = -range; dz <= range; dz++)
                    {
                        if (i + dx < 0 || i + dx >= MapX ||
                            j + dy < 0 || j + dy >= MapY ||
                            k + dz < 0 || k + dz >= MapZ) continue;
                        double distanceSquared = dx * dx + dy * dy + dz * dz;
                        if (distanceSquared == 0) continue; // prevent self-interaction

                        radiationEffect -= currentRadiationStrength * _baryonicVolume[i + dx, j + dy, k + dz] / distanceSquared;
                    }
                }
            }

            _baryonicVolume[i, j, k] += radiationEffect * timeInYears;
        });
    }

    private void ApplyExpansion(double timeInYears)
    {
        // The effect of dark energy accelerates the expansion of the universe
        var expansionFactor = 1.0 + (ExpansionRate + _darkEnergyEffect) * timeInYears;

        // Interpolate both volumes using the expanded factor
        _baryonicVolume = InterpolateVolume(_baryonicVolume, expansionFactor);
        _darkMatterVolume = InterpolateVolume(_darkMatterVolume, expansionFactor);
    }

    private void ApplyBaryonicFeedback(double timeInYears)
    {
        var feedbackEffects = new double[MapX, MapY, MapZ];
        var energyInjected = new double[MapX, MapY, MapZ]; // To track the change in energy due to feedback

        RunVolumeFunction((int i, int j, int k) =>
        {
            if (!(_baryonicVolume[i, j, k] > BaryonicFeedbackThreshold)) return;
            var feedback = BaryonicFeedbackStrength * timeInYears;
            _baryonicVolume[i, j, k] -= feedback;
            feedbackEffects[i, j, k] = feedback * BaryonicFeedbackSpread;

            // Increase in temperature due to feedback (energy injection)
            var energyChange = BaseHeatingRate * timeInYears;
            _temperatureVolume[i, j, k] += energyChange;
            energyInjected[i, j, k] = energyChange;
        });


        // Spread the feedback effects and the energy
        RunVolumeFunction((int i, int j, int k) =>
        {
            if (!(feedbackEffects[i, j, k] > 0)) return;

            for (var dx = -1; dx <= 1; dx++)
            {
                for (var dy = -1; dy <= 1; dy++)
                {
                    for (var dz = -1; dz <= 1; dz++)
                    {
                        if (i + dx < 0 || i + dx >= MapX ||
                            j + dy < 0 || j + dy >= MapY ||
                            k + dz < 0 || k + dz >= MapZ ||
                            dx == 0 && dy == 0 && dz == 0) continue;
                        _baryonicVolume[i + dx, j + dy, k + dz] += feedbackEffects[i, j, k] / 26.0;
                        _temperatureVolume[i + dx, j + dy, k + dz] += energyInjected[i, j, k] / 26.0;
                    }
                }
            }
        });
    }

    private void ApplyHeatingAndCooling(double timeInYears)
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            var localDensity = _baryonicVolume[i, j, k];
            var effectiveCoolingRate = BaseCoolingRate * (1 + CoolingRateDensityFactor * localDensity);
            var effectiveHeatingRate = BaseHeatingRate * (1 - HeatingRateDensityFactor * localDensity);
            effectiveCoolingRate += CollisionalCoolingFactor * localDensity * localDensity;
            effectiveHeatingRate += CollisionalHeatingFactor * localDensity * localDensity;

            var energyChangeDueToCooling = effectiveCoolingRate * timeInYears * _temperatureVolume[i, j, k];
            var energyChangeDueToHeating = effectiveHeatingRate * timeInYears;

            _temperatureVolume[i, j, k] -= energyChangeDueToCooling;
            _temperatureVolume[i, j, k] += energyChangeDueToHeating;

            _totalEnergy -= energyChangeDueToCooling;
            _totalEnergy += energyChangeDueToHeating;
        });
    }

    private double[,,] InterpolateVolume(double[,,] dataSet, double scaleFactor)
    {
        var expandedX = (int)(MapX * scaleFactor);
        var expandedY = (int)(MapY * scaleFactor);
        var expandedZ = (int)(MapZ * scaleFactor);

        var expandedVolume = new double[expandedX, expandedY, expandedZ];

        // Convert the 3D volume into a flat array for processing.
        var flatData = new double[MapX * MapY * MapZ];
        RunVolumeFunction((int i, int j, int k) => { flatData[i * MapY * MapZ + j * MapZ + k] = dataSet[i, j, k]; });

        // Interpolation
        RunVolumeFunction((int i, int j, int k) =>
        {
            // Convert expanded indices to original volume's scale
            int[] targetIndices =
            {
                    (int) (i / scaleFactor),
                    (int) (j / scaleFactor),
                    (int) (k / scaleFactor)
                };

            // Interpolate to get the value at the current position in the expanded volume
            expandedVolume[i, j, k] = _interpolationAlgorithm.Interpolate(flatData, null /* or some args instance */, new int[] { MapX, MapY, MapZ }, targetIndices);
        });

        return expandedVolume;
    }

    private void IdentifyStructures(double[,,] smoothedVolume)
    {
        RunVolumeFunction((int i, int j, int k) =>
        {
            var density = smoothedVolume[i, j, k];

            // Check against densityThreshold
            if (density < DensityThreshold)
            {
                // Void
                return;
            }

            if (density < StructureThreshold)
            {
                // Uninteresting region, can skip or label accordingly
                return;
            }

            var eigenValues = Hessian.EigenValues(i, j, k, smoothedVolume);

            switch (eigenValues[0])
            {
                case > 0 when eigenValues[1] > 0 && eigenValues[2] > 0:
                    // Node
                    break;
                case > 0 when eigenValues[1] > 0 && eigenValues[2] < 0:
                    // Filament
                    break;
                case > 0 when eigenValues[1] < 0 && eigenValues[2] < 0:
                    // Sheet
                    break;
                default:
                    // Other, or you can classify as void
                    break;
            }
        });
    }

    private int[,,] LabelConnectedComponents(double[,,] structureVolume, double threshold)
    {
        var labels = new int[MapX, MapY, MapZ]; // Volume to store labels
        var currentLabel = 1;

        RunVolumeFunction((int i, int j, int k) =>
        {
            if (!(structureVolume[i, j, k] > threshold) || labels[i, j, k] != 0) return;
            FloodFill(structureVolume, labels, i, j, k, currentLabel, threshold);
            currentLabel++;
        });

        return labels;
    }

    private void FloodFill(double[,,] structureVolume, int[,,] labels, int x, int y, int z, int label, double threshold)
    {
        var queue = new Queue<(int x, int y, int z)>();
        queue.Enqueue((x, y, z));

        while (queue.Count > 0)
        {
            var voxel = queue.Dequeue();
            if (voxel.x < 0 || voxel.x >= MapX ||
                voxel.y < 0 || voxel.y >= MapY ||
                voxel.z < 0 || voxel.z >= MapZ)
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

    private Dictionary<int, List<(int x, int y, int z)>> ExtractLabeledRegions(int[,,] labels)
    {
        var regions = new Dictionary<int, List<(int x, int y, int z)>>();

        for (var i = 0; i < labels.GetLength(0); i++)
        {
            for (var j = 0; j < labels.GetLength(1); j++)
            {
                for (var k = 0; k < labels.GetLength(2); k++)
                {
                    var label = labels[i, j, k];
                    if (label <= 0) continue;
                    if (!regions.ContainsKey(label))
                    {
                        regions[label] = new List<(int x, int y, int z)>();
                    }

                    regions[label].Add((i, j, k));
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
        var smoothedVolume = new double[MapX, MapY, MapZ];

        // Define a kernel radius based on sigma.
        var kernelRadius = (int)Math.Ceiling(3 * sigma);

        for (var i = 0; i < MapX; i++)
        {
            for (var j = 0; j < MapY; j++)
            {
                for (var k = 0; k < MapZ; k++)
                {
                    double sum = 0;
                    double weightSum = 0;

                    for (var dx = -kernelRadius; dx <= kernelRadius; dx++)
                    {
                        for (var dy = -kernelRadius; dy <= kernelRadius; dy++)
                        {
                            for (var dz = -kernelRadius; dz <= kernelRadius; dz++)
                            {
                                if (i + dx < 0 || i + dx >= MapX ||
                                    j + dy < 0 || j + dy >= MapY ||
                                    k + dz < 0 || k + dz >= MapZ) continue;
                                var weight = GaussianKernel(Math.Sqrt(dx * dx + dy * dy + dz * dz), sigma);
                                sum += weight * volume[i + dx, j + dy, k + dz];
                                weightSum += weight;
                            }
                        }
                    }

                    smoothedVolume[i, j, k] = sum / weightSum;
                }
            }
        }

        return smoothedVolume;
    }
}