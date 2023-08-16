// Function 1 - hello world

using System;

public static class Kata {
    public static string greet() {
        string gniteerg = "!dlrow olleh";
        char[] greeting = gniteerg.ToCharArray();
        Array.Reverse(greeting);
        string str = "";

        for (int i = 0; i < greeting.Length; i++)
            str += greeting[i];

        return str;
    } 
}