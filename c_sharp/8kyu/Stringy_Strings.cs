// Stringy Strings

public class Kata {
    public static string Stringy(int size) {
        string str = "10";
        if (size == 1)
            return "1";
        else if (size % 2 == 0) {
            for (int i = 2; i <= size / 2; i++)
                str += "10";
            return str;
        }
        else {
            for (int i = 2; i <= size / 2; i++)
                str += "10";
            str += "1";
            return str;
        }
    }
}