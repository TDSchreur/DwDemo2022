// Copyright (c) T.D.Schreur

using Serilog;

namespace App;

public class Demo4
{
    public Demo4()
    {
        int[][] values = new int[][] {
            new[] { 1, 2, 10 },
            new[] { 1, 2, 7, 3, 3, 10 },
            new[] { 1, 2 },
            new[] { 1, 3 },
            new[] { 1, 3, 5 },
            new[] { 2, 5, 6, 7 }
        };

        foreach (int[] value in values)
        {
            Log.Logger.Information("Value: {value} - switch: {match}", value, CheckSwitch(value));
        }
    }
    public static int CheckSwitch(int[] values) => values switch
    {
        [1, 2, .., 10] => 1,
        [1, 2] => 2,
        [1, _] => 3,
        [1, ..] => 4,
        [..] => 50,
        _ => throw new NotImplementedException()
    };
}
