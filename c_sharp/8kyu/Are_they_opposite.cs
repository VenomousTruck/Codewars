// They say that only the name is long enough to attract attention.
// They also said that only a simple Kata will have someone to solve it.
// This is a sadly story #1: Are they opposite?

public class Kata {
    public static bool IsOpposite(string s1, string s2) {
        if (s1.Length == 0 && s2.Length == 0)
            return false;
        if (s1.Length > s2.Length || s1.Length < s2.Length)
            return false;
        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] == System.Char.ToLower(s2[i])) {
                if (System.Char.ToUpper(s1[i]) != s2[i])
                    return false;
            }
            else {
                if (System.Char.ToLower(s1[i]) != s2[i])
                    return false;
            }
        }
        return true;
    }
}