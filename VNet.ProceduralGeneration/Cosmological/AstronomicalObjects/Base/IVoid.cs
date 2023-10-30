using System.Numerics;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects.Base
{
    public interface IVoid : IAstronomicalObjectGroup
    {
        public Vector3 Position { get; set; }
    }
}