using System;

namespace maximum_subarray
{
  class Program
  {

    public static int MaxSubArray(int[] nums)
    {
      int finalSum = int.MinValue, currentSum = 0;
      Console.WriteLine("currentSum before: " + currentSum);
      Console.WriteLine("finalSum before: " + finalSum);
      for (int i = 0; i < nums.Length; i++)
      {
        currentSum = currentSum + nums[i];
        Console.WriteLine("currentSum: " + currentSum);

        if (finalSum < currentSum)
          finalSum = currentSum;

        if (currentSum < 0)
          currentSum = 0;
        Console.WriteLine("currentSum: " + currentSum);
        Console.WriteLine("finalSum: " + finalSum);
      }
      return finalSum;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
      Console.WriteLine(MaxSubArray(new int[] { -1 }));
    }
  }
}
