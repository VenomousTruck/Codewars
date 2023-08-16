// Is n divisible by (...)?

using System;

namespace Codewars {
    public static class KataChallenge {
        public static bool IsDivisible(params int[] numbers) {
            int num = numbers[0];
            bool flag = true;

            for (int i = 1; i < numbers.Length; i++) {
                if (num % numbers[i] != 0) {
                    flag = false;
                }
            }

            return flag;
        }
    }
}