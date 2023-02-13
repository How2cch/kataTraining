using static System.String;
namespace CamelCaseMethod;


public static class Kata
{
    public static string CamelCase(this string str)   
    {  
        var strList = str.Split(' ').ToList();
        strList.RemoveAll(IsNullOrEmpty);
        var newStrList = strList.Select(text => text.First().ToString().ToUpper() + text.Substring(1));
        var result = Join("", newStrList);
        return result;
    }
}
