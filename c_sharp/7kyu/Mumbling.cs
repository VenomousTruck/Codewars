// Mumbling

using System;

public class Accumul {
    public static String Accum(string s) {
        string str = "";
        int counter = 0;
        
        foreach (char ch in s.ToUpper()) {
            if (counter != 0)
                str += "-";
            str += ch  + new string(char.ToLower(ch), counter);
            counter++;
        }

        return str;
    }
}