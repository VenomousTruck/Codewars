// Fake Binary

public class Kata {
    public static string FakeBin(string x) {
        string str = "";
        foreach (char c in x) {
            if (c < '5')
                str += "0";
            else
                str += "1";
        }

        return str;
    }
}