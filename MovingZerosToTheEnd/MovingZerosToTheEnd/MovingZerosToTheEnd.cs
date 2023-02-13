namespace MovingZerosToTheEnd;

public class Kata
{
    public static int[] Soulution(int[] arr)
    {
        var newArr = arr.ToList().OrderBy(num => num == 0);
        return newArr.ToArray();
    }
}