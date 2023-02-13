using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication1
{
    internal static class Program
    {
        
        public static int MaxSequence(int[] arr)
        {
            if (!arr.Any(num => num <= 0)) return arr.Sum();
            if (!arr.Any(num => num >= 0)) return 0;
            var sumList = new List<int>() { arr[0] };
            var currentNum = arr[0];
            for (var i = 1; i < arr.Length; i++)
            {
                currentNum += arr[i];
                sumList.Add(currentNum);
                Console.WriteLine(currentNum);
            }
            var maxIndex = sumList.IndexOf(sumList.Max());
            var minIndex = sumList.IndexOf(sumList.Min());
            for()
                Console.WriteLine("------------------------");
            Console.WriteLine(sumList.Max() - sumList.Min());
            return 0;
        }

        public static void Main()
        {
            MaxSequence(new[] {-2, 1, -3, 4, -1, 2, 1, -5, 4});
                                       

        }
    }
}