// Remove the minimum

using System;
using System.Collections.Generic;
using System.Linq;

public class Remover {
    public static List<int> RemoveSmallest(List<int> numbers) {
        if (numbers.Count == 0)
            return new List<int>();
        
        int[] arr = new int[numbers.Count];
        numbers.CopyTo(arr);
        List<int> list = arr.ToList();
        list.Remove(list.Min());
        
        return list;
    }
}