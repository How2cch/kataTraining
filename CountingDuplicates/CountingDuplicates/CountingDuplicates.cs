namespace CountingDuplicates;

public class Kata
{
    public static int Soulution(string str)
    {
        return str.ToLower().GroupBy(letter => letter).Count(letterGroup => letterGroup.Count() > 1);
    }
}