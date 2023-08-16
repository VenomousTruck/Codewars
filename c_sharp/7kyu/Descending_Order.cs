// Descending Order

using System;
using System.Linq;

public static class Kata {
    public static int DescendingOrder(int num) {
        int result = int.Parse(string.Concat($"{num}".OrderByDescending(ch => ch)));
        
        return result;
    }
}