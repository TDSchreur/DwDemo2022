// Copyright (c) T.D.Schreur

using Serilog;

namespace App;

public class Demo2
{
    public Demo2()
    {
        Measurement m1 = new(5);
        Log.Logger.Information("{Measurement}", m1);

        Measurement m2 = new();
        Log.Logger.Information("{Measurement}", m2);

        Measurement m3 = default;
        Log.Logger.Information("{Measurement}", m3);
    }

    public readonly struct Measurement
    {
        public Measurement(double value)
        {
            Value = value;
        }

        public Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }

        public Measurement(string description)
        {
            Description = description;
        }

        public double Value { get; init; }
        public string Description { get; init; } = "Ordinary measurement";

        public override string ToString() => $"{Value} ({Description})";
    }
}
