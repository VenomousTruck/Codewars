// Reverse List Order

using System.Linq;
using System.Collections.Generic;

public class Kata {
    public static List<int> ReverseList(List<int> list) {
        List<int> newList = new List<int>();
        int[] arr = new int[list.Count];
        list.CopyTo(arr);
        newList = arr.ToList();
        newList.Reverse();

        return newList;
    }
}