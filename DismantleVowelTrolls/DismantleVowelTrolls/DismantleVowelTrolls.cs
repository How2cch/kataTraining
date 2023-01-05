using System.Text.RegularExpressions;

namespace DismantleVowelTrolls;

public static class Kata
{
    private static readonly string[] Vowels = { "a", "e", "i", "o", "u" };
    public static string Disemvowel(string str)
    {
        foreach (var vowel in Vowels)
        {
            var matchCount = Regex.Matches(str, vowel).Count;
            while (matchCount > 0)
            {
                var index = str.IndexOf(vowel);
                str = str.Substring(0, index) + str.Substring(index + 1);
                matchCount--;
            }
            var upperMatchCount = Regex.Matches(str, vowel.ToUpper()).Count;
            while (upperMatchCount > 0)
            {
                var index = str.IndexOf(vowel.ToUpper());
                str = str.Substring(0, index) + str.Substring(index + 1);
                upperMatchCount--;
            }
        }
        return str;
    }
}