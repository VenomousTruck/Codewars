// Find the divisors!

using System;
using System.Collections.Generic;

public class Kata {
    public static int[] Divisors(int n) {
        var result = new List<int>();

        for (int i = 2; i < n; i++) {
            if (n % i == 0)
                result.Add(i);
        }

        return (result.Count > 0) ? result.ToArray() : null;
    }
}