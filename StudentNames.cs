using System.Diagnostics;

namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void DanielArbov()
    {
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.BackgroundColor=ConsoleColor.Yellow;
        Console.WriteLine("My Name Is Daniel Arbov");
        Console.ResetColor();
    }
}
