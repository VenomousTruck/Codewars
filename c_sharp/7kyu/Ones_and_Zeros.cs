// Ones and Zeros

using System;

namespace Solution {
    class Kata {
        public static int binaryArrayToNumber(int[] BinaryArray) {
            string str = "";

            for (int i = 0; i < BinaryArray.Length; i++)
                str += BinaryArray[i].ToString();
            
            string num = Convert.ToInt32(str, 2).ToString();
            
            return Convert.ToInt32(num);
        }
    }
}