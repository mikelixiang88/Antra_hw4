namespace Antra_hw4;

public class ReverseString
{
    public void reverse()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Method 1: Using Char Array
        string reversedString1 = ReverseStringUsingCharArray(input);
        Console.WriteLine("Reversed using char array: " + reversedString1);

        // Method 2: Using For Loop
        string reversedString2 = ReverseStringUsingForLoop(input);
        Console.WriteLine("Reversed using for loop: " + reversedString2);
    }

    private string ReverseStringUsingCharArray(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    private string ReverseStringUsingForLoop(string str)
    {
        string reversedString = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedString += str[i];
        }
        return reversedString;
    }
}