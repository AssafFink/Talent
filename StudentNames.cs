namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void DavidHaskell()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Green;

        Console.WriteLine("David Haskell");

        Console.ResetColor();
    }
}
