// Abbreviate a Two Word Name

public class Kata {
    public static string AbbrevName(string name) {
        string[] abbrev = name.Split();

        return char.ToUpper(abbrev[0][0]) + "." + char.ToUpper(abbrev[1][0]);  
    }
}