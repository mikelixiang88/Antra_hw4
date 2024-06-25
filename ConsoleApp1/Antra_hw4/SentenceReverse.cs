namespace Antra_hw4;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
public class SentenceReverse
{
    public void reverse()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        string reversedSentence = ReverseWordsInSentence(input);
        Console.WriteLine("Reversed sentence: " + reversedSentence);
    }

    private string ReverseWordsInSentence(string sentence)
    {
        // Define the separators
        string pattern = @"([.,:;=\(\)&\[\]\""\'\\\/!\?\s]+)";
        string[] parts = Regex.Split(sentence, pattern);

        // Separate words and separators
        List<string> words = new List<string>();
        List<string> separators = new List<string>();

        foreach (var part in parts)
        {
            if (Regex.IsMatch(part, pattern))
            {
                separators.Add(part);
            }
            else
            {
                words.Add(part);
            }
        }

        // Reverse the words
        words.Reverse();

        // Reconstruct the sentence
        List<string> result = new List<string>();
        int wordIndex = 0, separatorIndex = 0;

        foreach (var part in parts)
        {
            if (Regex.IsMatch(part, pattern))
            {
                result.Add(separators[separatorIndex++]);
            }
            else
            {
                result.Add(words[wordIndex++]);
            }
        }

        return string.Join("", result);
    }
}