// Beginner - Reduce but Grow

public class Kata {
    public static int Grow(int[] x) {
        if (x.Length == 0)
            return 0;

        int multiply = 1;
        
        for (int i = 0; i < x.Length; i++)
            multiply *= x[i];
        
        return multiply;
    }
}