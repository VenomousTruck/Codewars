// Welcome to the City

public class Kata {
    public static string SayHello(string[] name, string city, string state) {
        string str = "";
        
        for (int i = 0; i < name.Length; i++)
            str += name[i] + " ";
        
        str = str.Remove(str.Length - 1, 1);

        return "Hello, " + str + "! " + "Welcome to " + city + ", " + state + "!";
    }
}