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

    public static void Yonatan()
    {
        int x = Random.Shared.Next(1, 16);
        int y = Random.Shared.Next(1, 15);
        if (x == y) y += 1;
        Console.ForegroundColor = (ConsoleColor)x;
        Console.BackgroundColor = (ConsoleColor)y;
        Console.WriteLine("Yonatan");
        Console.ResetColor();
    }
}
