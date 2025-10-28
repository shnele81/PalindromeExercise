using System;
using System.Linq;

namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string word)
    {
        var wordReversed = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            wordReversed += word[i];
        }

        if (wordReversed == word)
        {
            return true;
        }
        return false;
    }
}