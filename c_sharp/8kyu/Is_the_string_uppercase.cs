// Is the string uppercase?

public static class StringExtensions {
    public static bool IsUpperCase(this string text) {
        bool okay = true;
        for (int i = 0; i < text.Length; i++) {
            if (text[i] != System.Char.ToUpper(text[i])) {
                okay = false;
                break;
            }
        }
        return okay;
    }
}