// Sum of two lowest positive integers

using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata {
    public static int sumTwoSmallestNumbers(int[] numbers) {
        List<int> list = numbers.ToList();
        int firstMin = list.Min();
        list.Remove(firstMin);
        int secondMin = list.Min();

        int sum = firstMin + secondMin;

        return sum;
    }
}