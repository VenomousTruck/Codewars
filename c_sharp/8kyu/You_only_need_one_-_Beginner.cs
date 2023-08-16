// You only need one - Beginner

using System.Linq;

public class Kata {
    public static bool Check(object[] a, object x) {
        if (a.Contains(x))
            return true;
        return false;
    }
}