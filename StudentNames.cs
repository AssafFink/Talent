﻿namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void Guy()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Students: Guy");
        Console.ResetColor();
    }
}
