namespace SquareEveryDigit;

public class Kata
{
    public static int SquareDigits(int n)
    {
        var numberToStr = n.ToString();
        var arr = numberToStr.ToCharArray();
        string result = "";
        foreach (var charText in arr)
        {
            var num = Math.Pow(charText - '0', 2).ToString();
            result += num;
        }
        return int.Parse(result);
    }
}