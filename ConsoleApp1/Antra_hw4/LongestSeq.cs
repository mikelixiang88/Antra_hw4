namespace Antra_hw4;

public class LongestSeq
{
    public void longest_seq()
    {
        Console.WriteLine("Enter the array of integers (space-separated):");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
        int maxLength = 1;
        int currentLength = 1;
        int bestStart = 0;
        int currentStart = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestStart = currentStart;
                }
            }
            else
            {
                currentLength = 1;
                currentStart = i;
            }
        }

        // Output result
        for (int i = bestStart; i < bestStart + maxLength; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}