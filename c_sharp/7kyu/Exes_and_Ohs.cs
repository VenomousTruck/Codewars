// Exes and Ohs

using System.Linq;
using System;
public static class Kata {
    public static bool XO (string input) {
        input = input.ToLower();
        int oCounter = 0;
        int xCounter = 0;

        for (int i = 0; i < input.Length; i++) {
            if (input[i] == 'o')
                oCounter++;
            if (input[i] == 'x')
                xCounter++;
        }
        
        if (oCounter == 0 && xCounter == 0)
            return true;
        else if (oCounter == xCounter)
            return true;
        else
            return false;
    }
}