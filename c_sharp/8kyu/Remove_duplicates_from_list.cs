// Remove duplicates from list

using System.Collections.Generic;

namespace Solution {
    public static class Program {
        public static int[] distinct(int[] a) {
            List<int> list = new List<int>();
            foreach(int x in a) {
                if (!list.Contains(x))
                    list.Add(x);
            }

            return list.ToArray();
        }
    }
}