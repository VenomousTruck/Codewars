// Remove String Spaces

using System;

namespace Solution {
    public static class SpacesRemover {
        public static string NoSpace(string input) {
            string[] str = input.Split();
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
                newStr += str[i];
            
            return newStr;
        }  
    }
}