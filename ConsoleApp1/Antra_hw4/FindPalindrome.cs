namespace Antra_hw4;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class FindPalindrome
{
    public void find()
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();

        List<string> palindromes = ExtractPalindromes(input);
        palindromes.Sort();

        Console.WriteLine("Palindromes: " + string.Join(", ", palindromes));
    }

    private List<string> ExtractPalindromes(string text)
    {
        HashSet<string> palindromes = new HashSet<string>();
        string pattern = @"\b\w+\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            string word = match.Value;
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        return palindromes.ToList();
    }

    private bool IsPalindrome(string word)
    {
        int len = word.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (word[i] != word[len - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}