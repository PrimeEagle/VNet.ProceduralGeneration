using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base;
using VNet.ProceduralGeneration.Cosmological.Contexts.Base;
using VNet.ProceduralGeneration.Cosmological.Enum;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Generators.Base;

public abstract class GroupGeneratorBase<T, TContext> : GeneratorBase<T, TContext>, IDisposable
                                                        where T : AstronomicalObjectGroup, new()
                                                        where TContext : GroupContextBase
{
    protected GroupGeneratorBase(EventAggregator eventAggregator, ParallelismLevel parallelismLevel) : base(eventAggregator, parallelismLevel)
    {
    }

    protected abstract void GenerateWarpedSurface(TContext context, T self);
    protected abstract void GenerateInteriorObjects(TContext context, T self);
    protected abstract void GenerateInteriorRandomizationAlgorithm(TContext context, T self);
    protected abstract void GenerateSurfaceNoiseAlgorithm(TContext context, T self);

    protected override void GenerateBaseProperties(TContext context, T self)
    {
        SetMatterType(context, self);
        GenerateDiameter(context, self);
        GeneratePosition(context, self);
        GenerateOrientation(context, self);
        GenerateBoundingBox(context, self);
        GenerateSurfaceNoiseAlgorithm(context, self);
        GenerateInteriorRandomizationAlgorithm(context, self);
        GenerateWarpedSurface(context, self);
    }

    protected virtual void ApplyGravitationalEffectsToInterior(TContext context, T self, float timeInYears)
    {
        if (!Settings.Basic.ApplyGravitationalEffects) return;

        var netDisplacements = new List<Vector3>();
        var netVelocities = new List<Vector3>();

        for (var i = 0; i < self.InteriorObjects.Count; i++)
        {
            netDisplacements.Add(Vector3.Zero);
            netVelocities.Add(Vector3.Zero);
        }

        for (var i = 0; i < self.InteriorObjects.Count; i++)
            for (var j = 0; j < self.InteriorObjects.Count; j++)
            {
                if (i == j) continue;

                var direction = self.InteriorObjects[j].Position - self.InteriorObjects[i].Position;
                var distance = direction.Length();

                if (Settings.Advanced.Application.ApplyGravitationalEffectsPreventDarkMatterClumping)
                    if (self.InteriorObjects[i].MatterType == MatterType.DarkMatter && self.InteriorObjects[j].MatterType == MatterType.DarkMatter && distance < Settings.Advanced.Application.MinimumDarkMatterDistanceToPreventClumping)
                        distance = Settings.Advanced.Application.MinimumDarkMatterDistanceToPreventClumping;

                direction = Vector3.Normalize(direction);

                var force = Settings.Advanced.PhysicalConstants.G * self.InteriorObjects[i].Mass * self.InteriorObjects[j].Mass / (distance * distance);
                var acceleration = force / self.InteriorObjects[i].Mass;
                var velocity = acceleration * timeInYears;
                var displacement = 0.5f * acceleration * timeInYears * timeInYears;

                if (Settings.Advanced.Application.ApplyGravitationalEffectsDampenBaryonicMatter)
                    if (self.InteriorObjects[i].MatterType == MatterType.BaryonicMatter)
                        velocity *= Settings.Advanced.Application.BaryonicMatterDampeningFactor;

                netVelocities[i] += Vector3.Multiply(direction, (float)velocity);
                netDisplacements[i] += Vector3.Multiply(direction, (float)displacement);
            }

        for (var i = 0; i < self.InteriorObjects.Count; i++) self.InteriorObjects[i].Position += netDisplacements[i];
    }

    protected override void PostProcess(TContext context, T self)
    {
        ApplyGravitationalEffectsToInterior(context, self, self.Age);
    }

    protected bool PointsOverlap(IEnumerable<IUndefinedAstronomicalObject> points, IUndefinedAstronomicalObject newPoint)
    {
        return points.Any(i => Vector3.Distance(i.Position, newPoint.Position) < 0.001f);
    }
}