// How good are you really?

public class Kata {
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints) {
        int sum = 0, average = 0;

        for (int i = 0; i < ClassPoints.Length; i++)
            sum += ClassPoints[i];
        
        sum += YourPoints;
        average = sum / (ClassPoints.Length + 1);
        
        return (YourPoints > average) ? true : false;
    }
}