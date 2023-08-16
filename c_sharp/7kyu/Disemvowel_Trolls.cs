// Disemvowel Trolls

using System;
using System.Linq;

public static class Kata {
    public static string Disemvowel(string str) {
        string newStr = "";
        newStr = string.Concat(str.Where(c => !"aeiouAEIOU".Contains(c)));

        return newStr;
    }
}   