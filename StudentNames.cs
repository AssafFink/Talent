namespace Talent;

internal static class StudentNames
{
    public static void Assaf()
    {
        Console.WriteLine("Teacher: Assaf");
    }

    public static void Orel()
    {
        Console.WriteLine("Orel");
        Console.WriteLine("-----------------");
        string name = "orel";
        int length = name.Length;
        int width = 2 * length - 1;

        for (int row = 0; row < length; row++)
        {
            for (int col = 0; col < width; col++)
            {
                int center = length - 1;
                int left = center - row;
                int right = center + row;

           
                if (col == left || col == right || row == length - 1)
                {
                    Console.Write(name[col % length]);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
}
