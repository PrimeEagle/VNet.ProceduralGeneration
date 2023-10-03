using VNet.ProceduralGeneration.Cosmological.AstronomicalObjects;
using VNet.System.Events;

namespace VNet.ProceduralGeneration.Cosmological.Events
{
    public static class EventBuilder
    {
        public static async void CreateGeneratingEvent(EventAggregator eventAggregator, string source, AstronomicalObject astronomicalObject)
        {
            var sourceName = GetName(source);
            var id = astronomicalObject != null ? astronomicalObject.Id : string.Empty;

            var e = new GeneratingEvent()
            {
                Id = id,
                Source = sourceName
            };

            await eventAggregator.PublishAsync(e);
        }

        public static async void CreateGeneratedEvent(EventAggregator eventAggregator, string source, AstronomicalObject astronomicalObject)
        {
            var sourceName = GetName(source);
            var id = astronomicalObject.Id;

            var e = new GeneratedEvent()
            {
                Id = id,
                Source = sourceName
            };

            await eventAggregator.PublishAsync(e);
        }

        public static async void CreatePostProcessingEvent(EventAggregator eventAggregator, string source, AstronomicalObject astronomicalObject)
        {
            var sourceName = GetName(source);
            var id = astronomicalObject.Id;

            var e = new PostProcessingEvent()
            {
                Id = id,
                Source = sourceName
            };

            await eventAggregator.PublishAsync(e);
        }

        public static async void CreatePostProcessedEvent(EventAggregator eventAggregator, string source, AstronomicalObject astronomicalObject)
        {
            var sourceName = GetName(source);
            var id = astronomicalObject.Id;

            var e = new PostProcessedEvent()
            {
                Id = id,
                Source = sourceName
            };

            await eventAggregator.PublishAsync(e);
        }

        private static string GetName(string source)
        {
            return source.Replace("Generator", "");
        }
    }
}