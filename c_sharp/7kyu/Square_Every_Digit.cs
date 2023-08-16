// Square Every Digit

using System;

public class Kata {
    public static long SquareDigits(int n) {
        string str = Convert.ToString(n);
        int num = 0;
        string s = "";
        string result = "";

        for (int i = 0; i < str.Length; i++) {
            num = Convert.ToInt32(str[i].ToString()) * Convert.ToInt32(str[i].ToString());
            s = Convert.ToString(num);
            result += s;
        }

        long resNum = Convert.ToInt64(result);

        return resNum;
    }
}