// Capitalization and Mutability

using System;

public class Kata {
    public static string CapitalizeWord(string word) {
        string str = "";
        str += Char.ToUpper(word[0]) + word.Substring(1);
        return str;
    }
}