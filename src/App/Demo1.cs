// Copyright (c) T.D.Schreur

using Serilog;

namespace App;

public class Demo1
{
    public Demo1()
    {
        Log.Logger.Information("""Hello World! We hebben nu RAW string literals :) Dus we kunnen quotes gebruiken => ""! """);

        string firstName = "Dennis";
        string lastName = "Schreur";
        string jsonString = $$"""
        { 
            "FirstName": "{{firstName}}", 
            "LastName": "{{lastName}}"
        }
        """;
        Log.Logger.Information("{json}", jsonString);
    }
}
