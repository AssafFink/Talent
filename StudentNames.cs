namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }
    public static void Aminov()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("Teacher: Aminov");
        Console.ResetColor();
    }
}
