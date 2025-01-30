namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void Yonatan()
    {
        Console.ForegroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
        Console.BackgroundColor = (ConsoleColor)Random.Shared.Next(1, 16);
        Console.WriteLine("Yonatan");
    }
}
