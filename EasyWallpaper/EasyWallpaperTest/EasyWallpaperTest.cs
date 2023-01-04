using EasyWallpaper;
namespace EasyWallpaperTest;

public static class WallpaperTests {
    private static void Testing(string actual, string expected) {
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public static void Test() 
    {
        Testing(Wallpaper.WallPaper(6.3, 4.5, 3.29), "sixteen");
        Testing(Wallpaper.WallPaper(7.8, 2.9, 3.29), "sixteen");
        Testing(Wallpaper.WallPaper(6.3, 5.8, 3.13), "seventeen");
        Testing(Wallpaper.WallPaper(6.1, 6.7, 2.81), "sixteen");
        Testing(Wallpaper.WallPaper(7.9, 0, 5.4), "zero");
        Testing(Wallpaper.WallPaper(5.4, 7.9, 0), "zero");
        Testing(Wallpaper.WallPaper(6.1, 6.7, 200.81), "twenty");
    }
}