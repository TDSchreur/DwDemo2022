// Copyright (c) T.D.Schreur

using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace App;

internal class Program
{
    private static void Main()
    {
        ////string templateA = "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}";
        string templateB = "{Message:lj}{NewLine}{Exception}{NewLine}";

        LoggerConfiguration loggerBuilder = new LoggerConfiguration()
                                            .Enrich.FromLogContext()
                                            .MinimumLevel.Information()
                                            .WriteTo.Console(outputTemplate: templateB, theme: AnsiConsoleTheme.Literate);

        Log.Logger = loggerBuilder.CreateLogger();
        Demo1 demo1 = new();
        Demo2 demo2 = new();
        Demo3 demo3 = new();
    }
}
