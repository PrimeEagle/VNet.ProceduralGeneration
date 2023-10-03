using Diagnostics.Sizeof;
using System.Numerics;
using System.Text;
using VNet.Mathematics.Randomization.Generation;

namespace VNet.ProceduralGeneration.Cosmological.AstronomicalObjects
{
    public abstract class AstronomicalObject : IAstronomicalObject
    {
        public string Id { get; init; }
        public float Age { get; set; }                      // years
        public double Mass { get; set; }                    // kg
        public float Size { get; set; }                     // AU
        public float Temperature { get; set; }             // Kelvin
        public Vector3 Position { get; set; }               // AU
        public float Lifespan { get; set; }                 // years
        public float AbsoluteMagnitude { get; set; }
        public AstronomicalObject Parent { get; set; }
        public Universe Universe => FindUniverse();




        protected AstronomicalObject()
        {
            this.Id = GenerateId();
        }

        protected AstronomicalObject(AstronomicalObject parent)
        {
            this.Id = GenerateId();
            this.Parent = parent;
        }

        public float EstimateSize()
        {
            return this.SizeInBytes();
        }

        private static string GenerateId()
        {
            var random = new DotNetGenerator();
            var ticks = DateTime.UtcNow.Ticks;
            ticks ^= (random.Next() << 8);
            var base36Ticks = Base36Encode(ticks);
            base36Ticks = base36Ticks.PadLeft(8, '0').Substring(base36Ticks.Length - 8, 8);

            return base36Ticks.Insert(4, "-");
        }

        private static string Base36Encode(long value)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = new StringBuilder();

            while (value > 0)
            {
                result.Insert(0, chars[(int)(value % 36)]);
                value /= 36;
            }

            return result.ToString();
        }

        private Universe FindUniverse()
        {
            var main = (AstronomicalObject)this;
            var parent = main.Parent;

            while (parent != null)
            {
                main = parent;
                parent = main.Parent;
            }

            return (Universe)main;
        }
    }
}