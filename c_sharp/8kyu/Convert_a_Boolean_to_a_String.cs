// Convert a Boolean to a String

using System;

public class kata {
    public static string BooleanToString(bool b) {
        switch(b) {
            case true:
                return "True";
            case false:
                return "False";
        }
    }
}