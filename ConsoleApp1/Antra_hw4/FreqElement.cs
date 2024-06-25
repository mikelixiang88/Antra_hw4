namespace Antra_hw4;

public class FreqElement
{
    public void find_freq()
    {
        Console.WriteLine("Enter the sequence of numbers (space-separated):");
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        // Count frequencies
        foreach (var num in arr)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
            }
        }

        // Find the most frequent number
        int mostFrequent = arr[0];
        int maxFrequency = 0;

        foreach (var pair in frequency)
        {
            if (pair.Value > maxFrequency || (pair.Value == maxFrequency && Array.IndexOf(arr, pair.Key) < Array.IndexOf(arr, mostFrequent)))
            {
                mostFrequent = pair.Key;
                maxFrequency = pair.Value;
            }
        }

        // Output result
        Console.WriteLine($"Most frequent number: {mostFrequent}");
    }
}