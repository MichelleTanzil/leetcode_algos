using System;
using System.Collections.Generic;
using System.Linq;

namespace last_stone_weight
{
  class Program
  {
      // My Solution
    public static int LastStoneWeight(int[] stones)
    {
      List<int> st = stones.ToList();
      if (st.Count == 0 || st == null) return 0;
      if (st.Count == 1) return st[0];
      else
      {
        st.Sort();
        int last = st.Count - 1;
        int secondLast = st.Count - 2;
        if (st[last] == st[secondLast])
        {
          st.RemoveAt(last);
          st.RemoveAt(secondLast);
        }
        else
        {
          st[secondLast] = st[last] - st[secondLast];
          st.RemoveAt(last);
        }
        return LastStoneWeight(st.ToArray());
      }
      // // Sorted Dictionary Solution
      // public int LastStoneWeight(int[] stones)
      // {
      //   var sorted = new SortedDictionary<int, int>();

      //   // put all numbers into minimum heap - default - negative value
      //   foreach (var number in stones)
      //   {
      //     var key = number * (-1);
      //     if (!sorted.ContainsKey(key))
      //     {
      //       sorted.Add(key, 0);
      //     }

      //     sorted[key]++;
      //   }

      //   while (!((sorted.Keys.Count == 1 && sorted[sorted.Keys.ToList()[0]] == 1) || sorted.Keys.Count == 0))
      //   {
      //     // get minimum two values from minimum heap
      //     var key = sorted.Keys.First();
      //     var hasAtLeastTwo = sorted[key] > 1;
      //     if (hasAtLeastTwo)
      //     {
      //       sorted[key] -= 2;
      //       if (sorted[key] == 0)
      //       {
      //         sorted.Remove(key);
      //       }
      //     }
      //     else
      //     {
      //       var minimum = key;
      //       sorted.Remove(key);
      //       var next = sorted.Keys.First();
      //       sorted[next]--;

      //       if (sorted[next] == 0)
      //       {
      //         sorted.Remove(next);
      //       }

      //       var diff = Math.Abs(minimum - next);
      //       var newKey = diff * (-1);

      //       if (newKey == 0)
      //         continue;

      //       if (!sorted.ContainsKey(newKey))
      //       {
      //         sorted.Add(newKey, 0);
      //       }

      //       sorted[newKey]++;
      //     }
      //   }

      //   if (sorted.Keys.Count == 0)
      //     return 0;

      //   return sorted.Keys.ToList()[0] * (-1);
      // }
    }
    static void Main(string[] args)
    {
      Console.WriteLine(LastStoneWeight(new int[] { 2, 7, 4, 1, 8, 1 }));
    }
  }
}
