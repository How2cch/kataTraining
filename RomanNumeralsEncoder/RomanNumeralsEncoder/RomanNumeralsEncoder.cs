namespace RomanNumeralsEncoder;

public class Kata
{
    private static Dictionary<string, int> _romanNumeralRules1 = new Dictionary<string, int>() { { "M", 1000 }, { "C", 100 }, { "X", 10 }, { "I", 1 } };
    private static Dictionary<string, int> _romanNumeralRules2 = new Dictionary<string, int>() { { "D", 500 }, { "L", 50 }, { "V", 5 } };
    private static List<KeyValuePair<string, int>> _rulesList1 = _romanNumeralRules1.ToList();
    private static List<KeyValuePair<string, int>> _rulesList2 = _romanNumeralRules2.ToList();

    public static string Solution(int n)
    {
        if (n < 1 || n > 3999) throw new NotImplementedException();
        string result = "";
        for (var i = 0; i < _rulesList1.Count(); i++) 
        {

            var numberOfTime = n / _rulesList1[i].Value;
            var text = RomanNumeralText(numberOfTime, _rulesList1[i].Key, i);
            result += text;
            n = n % _rulesList1[i].Value;
        }
        return result;
    }

    private static string RomanNumeralText(int numberOfTime, string romanNumeralChar, int index) 
    {
        string text = "";
        if (numberOfTime < 4)
        {
            for (var i = 0; i < numberOfTime; i++)
            {
                text += romanNumeralChar;
            }
            return text;
        }

        if (numberOfTime == 4)
        {
            text += romanNumeralChar;
            text += _rulesList2[index - 1].Key;
            return text;
        }

        if (numberOfTime == 5)
        {
            text += _rulesList2[index - 1].Key;
            return text;
        }

        if (numberOfTime < 9 && numberOfTime > 5)
        {
            text += _rulesList2[index - 1].Key;
            for (var i = 0; i < numberOfTime - 5; i++)
            {
                text += romanNumeralChar;
            }
            return text;
        }

        if (numberOfTime == 9)
        {
            text += romanNumeralChar;
            text += _rulesList1[index - 1].Key;
            return text;
        }

        return text;
    }
}

