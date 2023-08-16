// Vowel Count

using System;
using System.Linq;

public static class Kata {
    public static int GetVowelCount(string str) {
        string newStr = "";
        newStr = string.Concat(str.Where(ch => "aeiou".Contains(ch)));
        int vowelCount = newStr.Length;

        return vowelCount;
    }
}