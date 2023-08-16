// Sum of positive

using System;
using System.Linq;

public class Kata {
    public static int PositiveSum(int[] arr) {
        if (arr.Length == 0)
            return 0;
        else {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] >= 0)
                    sum += arr[i];
            }
            return sum;
        }
    }
}