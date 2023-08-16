// No zeros for heros

using System;

public class NoBoring {
    public static int NoBoringZeros(int n) {
        string str = n.ToString();

        if (str[str.Length - 1] == '0') {
            for (int i = str.Length - 1; i > 0; i--) {
                if (str[i] == '0')
                    str = str.Remove(i, 1);
                else
                    break;
            }
        }
        else
            return n;
        return Convert.ToInt32(str);
    }
}