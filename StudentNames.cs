using System.Diagnostics;

namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Assaf");
    }

    public static void Gil()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("Student: Gil");
        Console.ResetColor();
    }

  public static void Guy()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Guy");
       Console.ResetColor();
    }
  
    public static void GalAmrani()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Student: Gal amrani");
       Console.ResetColor();
    }
  
    public static void DavidHaskell()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("David Haskell");
        Console.ResetColor();
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

    public static void DanielArbov()
    {
        Console.ForegroundColor=ConsoleColor.Blue;
        Console.BackgroundColor=ConsoleColor.Yellow;
        Console.WriteLine("My Name Is Daniel Arbov");
        Console.ResetColor();
    }
    public static void Lior()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine("Lior");
        Console.ResetColor();
    }
}
