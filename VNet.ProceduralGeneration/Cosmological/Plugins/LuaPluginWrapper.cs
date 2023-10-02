using NLua;

namespace VNet.ProceduralGeneration.Cosmological.Plugins
{
    public class LuaPluginWrapper : IPlugin
    {
        private readonly string _luaScript;
        private readonly Lua _luaEnvironment;

        public LuaPluginWrapper(string luaScript, Lua luaEnvironment)
        {
            _luaScript = luaScript;
            _luaEnvironment = luaEnvironment;
        }

        public string Name => _luaEnvironment["Name"] as string;
        public string Author { get; }
        public string Version => _luaEnvironment["Version"] as string;
        public DateTime ReleaseDate { get; }

        public void Execute()
        {
            if (_luaEnvironment.GetFunction("Execute") is LuaFunction function)
            {
                function.Call();
            }
        }
    }
}