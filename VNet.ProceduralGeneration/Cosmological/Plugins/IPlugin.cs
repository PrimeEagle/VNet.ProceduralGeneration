namespace VNet.ProceduralGeneration.Cosmological.Plugins
{
    public interface IPlugin
    {
        public string Name { get; }
        public string Author { get; }
        public string Version { get; }
        public DateTime ReleaseDate { get; }




        public void Execute();
    }
}