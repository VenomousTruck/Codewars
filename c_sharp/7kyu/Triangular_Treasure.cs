// Triangular Treasure

using System;

public class Kata {
    public static int Triangular(int n) {
        int sum = 0;

        if (n < 0)
            return 0;
        else {
            for (int i = 1; i <= n; i++)
                sum += i;
            return sum;
        }
    }
}