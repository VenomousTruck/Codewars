// Convert number to reversed array of digits

using System;
using System.Collections.Generic;

namespace Solution {
    class Digitizer {
        public static long[] Digitize(long n) {
            string str = Convert.ToString(n);
            string newStr = "";
            string[] strArr;

            for (int i = str.Length - 1; i >= 0; i--)
                newStr += str[i] + " ";
            
            newStr = newStr.Remove(newStr.Length - 1, 1);
            strArr = newStr.Split();
            long[] arr = new long[strArr.Length];
            
            for (int i = 0; i < strArr.Length; i++)
                arr[i] += Convert.ToInt64(strArr[i]);
            
            return arr;
        }
    }
}