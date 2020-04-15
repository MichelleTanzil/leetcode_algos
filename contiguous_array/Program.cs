using System;
using System.Collections.Generic;

namespace contiguous_array
{
  class Program
  {
    public static int FindMaxLength(int[] nums)
    {
      Dictionary<int, int> dict = new Dictionary<int, int>();
      int count = 0;
      int maxLength = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        Console.WriteLine("count starting: " + count);
        Console.WriteLine("i: " + i);
        if (nums[i] == 1) count++;
        if (nums[i] == 0) count--;
        Console.WriteLine("count: " + count);
        if (dict.ContainsKey(count))
          maxLength = Math.Max(maxLength, i - dict[count]);
        else
          dict[count] = i;

        if (count == 0)
          maxLength = i + 1;
        Console.WriteLine("maxLength: " + maxLength);

      }
      return maxLength;
    }
    static void Main(string[] args)
    {
      // Console.WriteLine(FindMaxLength(new int[] { 0, 1, 0 }));
      Console.WriteLine(FindMaxLength(new int[] { 0, 1 }));
    }
  }
}
