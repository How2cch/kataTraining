namespace EasyWallpaper;

public class Wallpaper
{
    private static readonly string[] Numbers = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };

    public static string WallPaper(double l, double w, double h)
    {
        if(l <= 0 || w <= 0 || h <= 0) return Numbers[0];
        var totalArea = (l * h + w * h) * 2;
        var wallpaperOfUnit = 0.52 * 10;
        var buffer = 1.15;
        var resultNumberIndex = Convert.ToInt32(System.Math.Ceiling(totalArea / wallpaperOfUnit * buffer));
        return resultNumberIndex <= 19 ? Numbers[resultNumberIndex] : "twenty";
    }
}