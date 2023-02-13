using System.Numerics;

namespace PerimeterOfSquares;

public class Kata
{
    public static BigInteger Soulution(BigInteger n) 
    {
        BigInteger[] sidelengthArray = new BigInteger[(int)n + 1];
        sidelengthArray[0] = 1;
        sidelengthArray[1] = 1;
        var currentIndex = 2;
        while (sidelengthArray[(int)n] == 0)
        {
            sidelengthArray[currentIndex] = sidelengthArray[currentIndex - 1] + sidelengthArray[currentIndex - 2];
            currentIndex++;
        }
        var result = (BigInteger) 0;
        foreach (var i in sidelengthArray)
        {
            result += i;
        }
    
        return result * 4;
    }

    public static BigInteger Soulution2(BigInteger n) 
    {
        BigInteger a = 1, b = 1, sum = 0, total = 2;
        for(var index = 2; index < n + 1; index++)
        {
            sum = a + b;
            a = b;
            b = sum;
            total += b;
        }
        return total * 4;
    }
}