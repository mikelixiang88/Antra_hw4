namespace Antra_hw4;

public class ArrayPractice
{
    public void arraycopy()
    {
        // Create an initial array with 10 items and assign values
        int[] originalArray = new int[10];
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = i + 1; // Assign values 1 to 10
        }

        // Create a second array with the same length as the first array
        int[] copiedArray = new int[originalArray.Length];

        // Copy values from the original array to the new array
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        // Print out the contents of both arrays to ensure they are identical
        Console.WriteLine("Original Array: ");
        PrintArray(originalArray);

        Console.WriteLine("Copied Array: ");
        PrintArray(copiedArray);
    }
    public void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    public void ManageElement()
    {
        List<string> itemList = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                continue;
            }

            char command = input[0];
            string item = input.Length > 1 ? input.Substring(2).Trim() : string.Empty;

            if (command == '+')
            {
                if (!string.IsNullOrEmpty(item))
                {
                    itemList.Add(item);
                    Console.WriteLine($"Added: {item}");
                }
                else
                {
                    Console.WriteLine("Invalid item. Please try again.");
                }
            }
            else if (input == "--")
            {
                itemList.Clear();
                Console.WriteLine("List cleared.");
            }
            else if (command == '-')
            {
                if (itemList.Remove(item))
                {
                    Console.WriteLine($"Removed: {item}");
                }
                else
                {
                    Console.WriteLine($"Item not found: {item}");
                }
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }

            Console.WriteLine("Current list:");
            if (itemList.Count == 0)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                foreach (var listItem in itemList)
                {
                    Console.WriteLine("- " + listItem);
                }
            }
        }
    }
    public int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }

        return primes.ToArray();
    }

    public bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}