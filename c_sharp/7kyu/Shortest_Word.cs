// Shortest Word

public class Kata {
    public static int FindShort(string s) {
        string[] str = s.Split();
        int minLength = 10000000;

        for (int i = 0; i < str.Length; i++) {
            if (str[i].Length < minLength)
                minLength = str[i].Length;
        }
        
        return minLength;
    }
}