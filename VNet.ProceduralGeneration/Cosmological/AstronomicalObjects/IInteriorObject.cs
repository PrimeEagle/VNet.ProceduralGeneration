using System.Numerics;
using VNet.ProceduralGeneration.Cosmological.Enum;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public interface IInteriorObject
    {
        public double Mass { get; set; }                                                    // kg
        public Vector3 Position { get; set; }                                               // AU
        public MatterType MatterType { get; set; }
    }
}