using System.Reflection;
using NLua;
using VNet.Configuration;
using VNet.ProceduralGeneration.Cosmological.Configuration;

namespace VNet.ProceduralGeneration.Cosmological.Plugins
{
    public class PluginLoader
    {
        private GeneratorSettings settings = ConfigurationSettings<GeneratorSettings>.AppSettings;




        public List<IPlugin> LoadCSharpPlugins()
        {
            return (from file in Directory.GetFiles(settings.Basic.CSharpPluginFolder, "*.dll")
                    select Assembly.LoadFile(file) 
                    into assembly 
                    from type in assembly.GetTypes()
                    where type.GetInterfaces().Contains(typeof(IPlugin))
                    select Activator.CreateInstance(type) as IPlugin).ToList();
        }

        public IPlugin LoadLuaPlugin()
        {
            var luaScript = File.ReadAllText(settings.Basic.LuaPluginFolder);
            using Lua lua = new();
            lua.DoString(luaScript);

            return new LuaPluginWrapper(luaScript, lua);
        }
    }
}