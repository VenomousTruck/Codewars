// Reversed Strings

using System;

public static class Kata {
    public static string Solution(string str) {
        string newStr = "";
        
        for (int i = str.Length - 1; i >= 0; i--)
            newStr += str[i];

        return newStr;
    }
}