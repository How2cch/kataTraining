using System.Text.RegularExpressions;

namespace VowelCount;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        var vowelCount = 0;
        string[] vowels = { "a", "e", "i", "o", "u" };
        foreach (string vowel in vowels)
        { 
            MatchCollection match = Regex.Matches(str, vowel);
            vowelCount += match.Count;
        }
        return vowelCount;
    }
}
