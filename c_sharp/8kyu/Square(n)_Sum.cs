// Square(n) Sum

public static class Kata {
    public static int SquareSum(int[] numbers) { 
        int sum = 0;
        if (numbers.Length == 0)
            return 0;
        else {
            for (int i = 0; i < numbers.Length; i++)
                sum += numbers[i] * numbers[i];
            return sum;
        }
    }
}