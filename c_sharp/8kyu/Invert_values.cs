// Invert values

using System.Linq;

namespace Solution {
    public static class ArraysInversion {
        public static int[] InvertValues(int[] input) {
            return input.Select(num => -num).ToArray();
        }
    }
}