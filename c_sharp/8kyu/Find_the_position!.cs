// Find the position!

using System;

public class Kata {
    public static string Position(char alphabet) {
        alphabet = char.ToLower(alphabet);
        string str = "abcdefghijklmnopqrstuvwxyz";
        string newStr = Convert.ToString(str.IndexOf(alphabet) + 1);

        return "Position of alphabet: " + newStr;
    }
}