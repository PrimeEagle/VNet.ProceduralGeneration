using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Events
{
    public class CosmologicalEventBase : EventBase
    {
        public string Id { get; init; }
        public string Source { get; init; }
    }
}