namespace Antra_hw4;

public class RotateSum
{
    public void start()
    {
        // Read array and k
        Console.WriteLine("Enter the array of integers (space-separated):");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
        Console.WriteLine("Enter the number of rotations:");
        int k = int.Parse(Console.ReadLine());
            
        int n = arr.Length;
        int[] sumArray = new int[n];

        // Perform k rotations and sum the arrays
        for (int r = 1; r <= k; r++)
        {
            int[] rotatedArray = new int[n];

            // Rotate array
            for (int i = 0; i < n; i++)
            {
                rotatedArray[(i + r) % n] = arr[i];
            }

            // Sum arrays
            for (int i = 0; i < n; i++)
            {
                sumArray[i] += rotatedArray[i];
            }
        }

        // Output result
        Console.WriteLine(string.Join(" ", sumArray));
    }
}