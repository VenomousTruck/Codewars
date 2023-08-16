// Regex count lowercase letters

using System;

public class Kata {
    public static int LowercaseCountCheck(string s) {
        int lowerCaseCounter = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] != Char.ToUpper(s[i]))
                lowerCaseCounter++;
        }
        
        return lowerCaseCounter;
    }
}