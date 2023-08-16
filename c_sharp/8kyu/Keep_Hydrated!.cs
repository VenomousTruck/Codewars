// Keep Hydrated!

using System;

public class Kata {
    public static int Litres(double time) {
        double litre = 0.5d;

        return Convert.ToInt32(Math.Floor(time * litre));
    }
}