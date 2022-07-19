// C-like Object Oriented Language 11

using Serilog;

namespace App;

public class Demo3
{
    public Demo3()
    {
        ReadOnlySpan<char> ABC = "ABC".AsSpan();
        ReadOnlySpan<char> DEF = "DEF".AsSpan();

        Log.Logger.Information("Is {Input} gelijk aan ABC: {IsABC}", ABC.ToString(), IsABC(ABC));
        Log.Logger.Information("Is {Input} gelijk aan ABC: {IsABC}", DEF.ToString(), IsABC(DEF));
    }

    private static bool IsABC(ReadOnlySpan<char> s)
    {
        return s switch
        {
            ////"ABC" => true,
            _ => false
        };
    }
}
