// Highest and Lowest

using System;
using System.Linq;

public static class Kata {
    public static string HighAndLow(string numbers) {
        string[] substrings = numbers.Split();
        int[] nums = substrings.Select(int.Parse).ToArray();
 
        return (nums.Max() + " " + nums.Min());
    }
}