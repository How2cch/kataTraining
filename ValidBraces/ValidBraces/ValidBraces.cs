namespace ValidBraces;

public class Kata {

    private static List<char> bracesList = new List<char>();
    private static int index;
    private static int loopCount;
    private static int totalLoopCount;
    private static char lastBrace;
    private static Dictionary<char, char> braceDictionary = new Dictionary<char, char>() 
        {
            ['}'] = '{',
            [')'] = '(', 
            [']'] = '['
        };
    public static bool Soulution(String braces)
    {
        totalLoopCount = 0;
        loopCount = 0;
        index = 0;
        lastBrace= ' ';
        bracesList = braces.ToList();
        if (bracesList.Count() % 2 == 1) return false;
        totalLoopCount = bracesList.Count() / 2;
        bool result = filterBraces(bracesList);
        return result;
    }

    private static bool filterBraces(List<char> braces)
    {
        
        loopCount++;
        foreach (var brace in braces)
        {
            if (braceDictionary.ContainsKey(brace) && braceDictionary[brace] == lastBrace)
            {
                bracesList.RemoveAt(index);
                bracesList.RemoveAt(index - 1);
                lastBrace = ' ';
                break;
            }
            index++;
            lastBrace= ' ';
            lastBrace = brace;
        }
        index = 0;
        if (bracesList.Any()) 
        {
            if (totalLoopCount == loopCount) return false;
            return filterBraces(bracesList);
        }
        return true;
    }

    public static bool Soulution2(String braces) {
    var st = new Stack<char>();
    foreach (var c in braces)
      switch (c)
      {
        case '(':
        case '[':
        case '{':
          st.Push(c);
          continue;
        case ')':
          if (st.Count == 0 || st.Pop() != '(') return false;
          continue;
        case ']':
          if (st.Count == 0 || st.Pop() != '[') return false;
          continue;
        case '}':
          if (st.Count == 0 || st.Pop() != '{') return false;
          continue;
      }
    return st.Count == 0;
  }

    public static bool Soulution3(String str) 
    {
        string prev = "";
        while (str.Length != prev.Length)
        {
            prev = str;
            str = str
                .Replace("()", String.Empty)
                .Replace("[]", String.Empty)
                .Replace("{}", String.Empty);                
        }
        return (str.Length == 0);
    }
}
