namespace VNet.ProceduralGeneration.Cosmological.Configuration;

internal static partial class Constants
{
    internal static partial class Advanced
    {
        internal static class Plugin
        {
            internal static string ApiVersion { get; } = "1.0";
            internal static string[] CompatibleApiVersions { get; } = { "1.0" };
            internal static string CSharpPluginFolder { get; } = "plugins_csharp";
            internal static string LuaPluginFolder { get; } = "plugins_lua";
        }
    }
}