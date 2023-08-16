// Beginner - Lost Without a Map

//public class Kata {
//    public static int[] Maps(int[] x) {
//        int[] arr = new int[x.Length];
//
//        for (int i = 0; i < arr.Length; i++)
//            arr[i] = x[i] * 2;
//        
//        return arr;
//    }
//}

using System.Linq;

public class Kata {
    public static int[] Maps(int[] x) {
        return x.Select(num => num * 2).ToArray();
    }
}