// Sentence Smash

using System;

public class Kata {
    public static string Smash(string[] words) {
        string str = "";

        for (int i = 0; i < words.Length; i++)
            str += words[i] + " ";
        
        str = str.Remove(str.Length - 1, 1);
        
        return str;
    }
}