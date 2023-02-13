namespace SplitString;

public class Kata
{
    public static string[] Solution(string str)
    {
        str += str.Length % 2 == 0 ? String.Empty : "_";
        int loopNum = str.Length / 2;
        string[] result = new string[loopNum];
        for (var index = 0; index < loopNum; index++)
        {
            result[index] = str[index * 2].ToString() + str[index * 2 + 1].ToString();
            Console.WriteLine(result[index]);
        }
        return result;
    }
}