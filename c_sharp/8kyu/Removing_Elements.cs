// Removing Elements

using System.Linq;

public static class Kata {
    public static object[] RemoveEveryOther(object[] arr) {
        var arrList = arr.ToList();
        for (var i = arr.Length - 1; i > 0; i--) {
            if (i % 2 == 1)
                arrList.RemoveAt(i);
        }
        return arrList.ToArray();
    }
}