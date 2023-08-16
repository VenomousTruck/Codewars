// Credit Card Mask

using System;

public static class Kata {
    public static string Maskify(string cc) {
        char[] ch = cc.ToCharArray();
        string res = "";

        for (int i = 0; i < cc.Length - 4; i++)
            ch[i] = '#';

        res = string.Concat(ch);

        return res;
    }
}