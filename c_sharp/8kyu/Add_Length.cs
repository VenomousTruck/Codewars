// Add Length

public class Kata {
    public static string[] AddLength(string str) {
        var words = str.Split(new[] { " " }, System.StringSplitOptions.RemoveEmptyEntries);
        string[] newStr = new string[words.Length];
        int letterCounter = 0;
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words[i].Length; j++) {
                letterCounter++;
            }
            newStr[i] = words[i] + " " + letterCounter;
            letterCounter = 0;
        }
        return newStr;
    }
}