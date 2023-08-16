// Jaden Casing Strings

using System;

public static class JadenCase {
    public static string ToJadenCase(this string phrase) {
        string[] str = phrase.Split();

        for (int i = 0; i < str.Length; i++)
            str[i] = str[i].ToLower();

        string newStr = "";

        foreach (string s in str)
            newStr += char.ToUpper(s[0]) + s.Remove(0, 1) + " ";

        newStr = newStr.Remove(newStr.Length - 1, 1);

        return newStr;
    }
}