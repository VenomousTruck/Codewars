// Count of positives / sum of negatives

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
    public static int[] CountPositivesSumNegatives(int[] input) {
        if (input == null || input.Length == 0)
            return new int[] {};

        int positiveCount = 0;
        int negativeSum = 0;

        for (int i = 0; i < input.Length; i++) {
            if (input[i] > 0)
                positiveCount++;
            if (input[i] < 0)
                negativeSum += input[i];
        }

        int[] arr = { positiveCount, negativeSum };

        return arr;
    }
}