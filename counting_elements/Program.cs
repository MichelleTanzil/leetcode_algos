using System;
using System.Collections.Generic;
using System.Linq;

namespace counting_elements
{
  class Program
  {
    public static int CountElements(int[] arr)
    {
      // Second solution that works
      int finalCount = 0;
      Dictionary<int, int> dict = new Dictionary<int, int>();
      for (int i = 0; i < arr.Length; i++)
      {
        if (!dict.ContainsKey(arr[i])) dict[arr[i]] = 1;
        else dict[arr[i]]++;
      }
      foreach (var item in dict)
      {
        if (item.Value > 0)
        {
          if (dict.ContainsKey(item.Key + 1))
          {
            finalCount += item.Value;
          }
        }
      }
      return finalCount;

      // Initial Solution
      // int finalCount = 0, dupeCount = 0;
      // Array.Sort(arr);
      // for (int i = 0; i < arr.Length - 1; i++)
      // {
      //   if (arr[i] + 1 == arr[i + 1] && dupeCount == 0) finalCount++;
      //   else if (arr[i] + 1 == arr[i + 1] && dupeCount != 0)
      //   {
      //     int copy = dupeCount;
      //     Console.WriteLine("dupeCount: " + dupeCount);
      //     for (int j = 1; j <= copy + 1; j++)
      //     {
      //       if (i + j > arr.Length - 1) break;
      //       if (arr[i] + 1 == arr[i + j])
      //       {
      //         finalCount += dupeCount;
      //         dupeCount = 0;
      //       }
      //       else dupeCount = 0;
      //     }
      //   }
      //   if (arr[i] == arr[i + 1])
      //   {
      //     Console.WriteLine("i : " + i);
      //     dupeCount += 2;
      //     Console.WriteLine("dupeCount added: " + dupeCount);
      //   }
      //   if(arr[i] != arr[i+1] && dupeCount > 0) dupeCount = 0;
      // }
    }
    static void Main(string[] args)
    {
      // Console.WriteLine(CountElements(new int[] { 1, 3, 2, 3, 5, 0 }));
      // Console.WriteLine(CountElements(new int[] { 1, 1, 3, 3, 5, 5, 7, 7 }));
      // Console.WriteLine(CountElements(new int[] { 1, 2, 3 }));
      // Console.WriteLine(CountElements(new int[] { 1, 1, 2, 2 }));
      // Console.WriteLine(CountElements(new int[] { 1, 1, 2 }));
      // Console.WriteLine(CountElements(new int[] { 2, 9, 0, 7, 6, 2, 7, 7, 0 }));
      // Console.WriteLine(CountElements(new int[] { 6, 3, 11, 6, 11, 1, 11, 4, 7, 6, 13, 4, 1 }));
    }
  }
}
