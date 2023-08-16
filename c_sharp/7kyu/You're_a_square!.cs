// You're a square!

using System;

public class Kata {
    public static bool IsSquare(int n) {
        bool flag = false;

        if (n == 0)
            flag = true;
        else { 
            for (int i = 1; i <= Math.Sqrt(n); i++) {
                if (i * i == n)
                    flag = true;
            }
        }
        
        return flag;
    }
}