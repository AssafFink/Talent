namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void Orel()
    {
        string name = "orel";
        int length = name.Length;
        int width = 2 * length - 1;
        ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Cyan };

        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < width; col++)
            {
                int center = length - 1;
                int left = center - row;
                int right = center + row;

                if (col == left || col == right || row == length - 1)
                {
                    Console.ForegroundColor = colors[col % colors.Length];
                    Console.Write(name[col % name.Length]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        Console.ResetColor();
    }
}


