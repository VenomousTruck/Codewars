// Reverse words

using System;
using System.Linq;

public static class Kata {
    public static string ReverseWords(string str) {
        string newStr = string.Join(" ", str.Split().Select(ch => string.Concat(ch.Reverse())));

        return newStr;
    }
}