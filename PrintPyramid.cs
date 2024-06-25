using System;

namespace PrintPyramid
{
    class PrintPyramid
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of levels for the pyramid: ");
            if (int.TryParse(Console.ReadLine(), out int levels))
            {
                PrintPyramid(levels);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        static void PrintPyramid(int levels)
        {
            for (int i = 1; i <= levels; i++)
            {
                // Print spaces
                for (int j = 1; j <= levels - i; j++)
                {
                    Console.Write(" ");
                }
                
                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                
                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
