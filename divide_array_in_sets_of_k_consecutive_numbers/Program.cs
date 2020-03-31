using System;
using System.Collections.Generic;
using System.Linq;
namespace divide_array_in_sets_of_k_consecutive_numbers
{
  class Program
  {
    public static bool IsPossibleDivide(int[] nums, int k)
    {
      if (nums.Length % k != 0) return false;
      Array.Sort(nums);
      Dictionary<int, int> dict = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length; i++)
      {
        if (dict.ContainsKey(nums[i])) dict[nums[i]]++;
        else dict[nums[i]] = 1;
      }
      for (int i = 0; i < nums.Length; i++)
      {
        int currentVal = nums[i];
        if (dict[currentVal] > 0)
        {
          for (int j = 0; j < k; j++)
          {
            if (!dict.ContainsKey(currentVal + j))
            {
              return false;
            }
            dict[currentVal + j]--;
          }
        }
      }
      return true;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(IsPossibleDivide(new int[] { 1, 2, 3, 3, 4, 4, 5, 6 }, 4));
      Console.WriteLine(IsPossibleDivide(new int[] {3, 2, 1, 2, 3, 4, 3, 4, 5, 9, 10, 11}, 3));
      Console.WriteLine(IsPossibleDivide(new int[] {3, 3, 2, 2, 1, 1}, 3));
      Console.WriteLine(IsPossibleDivide(new int[] {1, 2, 3, 4}, 3));
      Console.WriteLine(IsPossibleDivide(new int[] {15, 16, 17, 18, 19, 16, 17, 18, 19, 20, 6, 7, 8, 9, 10, 3, 4, 5, 6, 20 }, 5));
    }
  }
}

