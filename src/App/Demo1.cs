// Copyright (c) T.D.Schreur

using Serilog;

namespace App;

public class Demo1
{
    public Demo1()
    {
        string message = """Hello World! We hebben nu RAW string literals :) Dus we kunnen quotes gebruiken => ""! """;
        Log.Logger.Information("{Message}", message);

        string firstName = "Dennis";
        string lastName = "Schreur";
        string jsonString = $$"""
        { 
            "FirstName": "{{firstName}}", 
            "LastName": "{{lastName}}"
        }
        """;
        Log.Logger.Information("{Json}", jsonString);
    }
}
