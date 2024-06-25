namespace Antra_hw4;

public class PrintPyramid
{
    public void PrintP(int levels)
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