// C-like Object Oriented Language 11

using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace App;

internal class Program
{
    private static void Main()
    {
        string template = "{Message:lj}{NewLine}{Exception}{NewLine}";

        LoggerConfiguration loggerBuilder = new LoggerConfiguration()
                                            .Enrich.FromLogContext()
                                            .MinimumLevel.Information()
                                            .WriteTo.Console(outputTemplate: template, theme: AnsiConsoleTheme.Code);

        Log.Logger = loggerBuilder.CreateLogger();
        Demo1 demo1 = new();
        //Demo2 demo2 = new();
        //Demo3 demo3 = new();
        //Demo4 demo4 = new();
        //Demo5 demo5 = new();
        //Demo7 demo7 = new();
        //Demo8 demo8 = new();
        //Demo9 demo9 = new();
    }
}
