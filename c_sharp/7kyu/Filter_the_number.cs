// Filter the number

using System;
using System.Linq;

public class Kata {
    public static int FilterString(string s) {
        string newStr = "";
        newStr = string.Concat(s.Where(ch => "1234567890".Contains(ch)));
        int num = Convert.ToInt32(newStr);

        return num;
    }
}