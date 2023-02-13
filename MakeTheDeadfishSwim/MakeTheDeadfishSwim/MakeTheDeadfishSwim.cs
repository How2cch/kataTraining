public class Kata
{
    public static int[] Soulution(string  data)
    {
        var current = 0;
        var result = new List<int>();
        var rulesList = data.Where(x => x is 'i' or 'd' or 's' or 'o');
        foreach (var rule in rulesList)
        {
            switch (rule)
            {
                case 'i':
                    current++;
                    break;
                case 'd':
                    current--;
                    break;
                case 's':
                    current = current * current;
                    break;
                case 'o':
                    result.Add(current);
                    break;
            }
        }

        return result.ToArray();
    }
}