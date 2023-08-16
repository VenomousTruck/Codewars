// Isograms

using System;

public class Kata {
    public static bool IsIsogram(string str) {
        bool flag = true;
        str = str.ToLower();

        for (int i = 0; i < str.Length; i++) {
            for (int j = i + 1; j < str.Length; j++) {
                if (str[i] == str[j])
                    flag = false;
            }
        }
        
        return flag;
    }
}