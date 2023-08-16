// String repeat

using System;

namespace Solution {
    public static class Program {
        public static string RepeatStr(int n, string s) {
            string newStr = "";

            for (int i = 0; i < n; i++)
                newStr += s;
            
            return newStr;
        }
    }
}