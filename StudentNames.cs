namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void Gil()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("Student: Gil");
        Console.ResetColor();
    }
}
