using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting.Json;

namespace  LoginToWebSite.LogsManager;

internal static class Logger
{
    private static string filePath = Directory.GetParent(@"../../../")?.FullName +
                                     Path.DirectorySeparatorChar + "/Logs/";
    private static readonly LoggingLevelSwitch levelSwitch = new LoggingLevelSwitch(LogEventLevel.Information);

    public static void CreateLogger()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.ControlledBy(levelSwitch)
            .WriteTo.File(new JsonFormatter(), Logger.filePath + @"Logs.json").CreateLogger();
    }
}