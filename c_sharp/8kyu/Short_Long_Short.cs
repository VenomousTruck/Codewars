// Short Long Short

public class ShortLongShort {
    public static string Solution(string a, string b) {
        if (a.Length > b.Length)
            return b + a + b;
        else if (a.Length < b.Length)
            return a + b + a;
        else
            return "";
    }
}