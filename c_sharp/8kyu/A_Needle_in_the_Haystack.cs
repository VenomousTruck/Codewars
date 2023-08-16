// A Needle in the Haystack

using System.Linq;

public class Kata {
    public static string FindNeedle(object[] haystack) {
        return $"found the needle at position {haystack.ToList().IndexOf("needle")}";
    }
}