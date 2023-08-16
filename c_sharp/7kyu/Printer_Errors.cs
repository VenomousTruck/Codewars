// Printer Errors

using System;

public class Printer {
    public static string PrinterError(String s) {
        char[] alphabet = { 'n', 'o', 'p', 'q', 'r',
                            's', 't', 'u', 'v', 'w', 
                            'x', 'y', 'z' };
        
        int errorCount = 0;

        for (int i = 0; i < s.Length; i++) {
            for (int j = 0; j < alphabet.Length; j++) {
                if (s[i] == alphabet[j])
                    errorCount++;
            }
        }

        return $"{errorCount}/{s.Length}";
    }
}