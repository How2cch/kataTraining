namespace OrderedCountOfCharacters;

public class Kata
{
    public static List<Tuple<char, int>> OrderedCount(string input)
    {
        List<Tuple<char, int>> result = new List<Tuple<char, int>>() { };
        char[] arr = input.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            bool isExist = false;
            for (var index = 0; index < result.Count; index++)
            {
                if (result[index].Item1 == arr[i])
                {
                    isExist = true;
                    result[index] = new Tuple<char, int>(arr[i], result[index].Item2 + 1);
                    break;
                }
            }

            if (!isExist) result.Add(new Tuple<char, int>(arr[i], 1));
        }

        return result;
    }
}