using System;

namespace move_zeros
{
  class Program
  {
    public static void MoveZeroes(int[] nums)
    {
      int count = 0;
      for (int i = 0; i < nums.Length; i++)
      {
        // Console.WriteLine("i: " + i);
        // Console.WriteLine("Count before: " + count);
        if (nums[i] != 0) nums[count++] = nums[i];
        // Console.WriteLine("Count after: " + count);
        // for (int k = 0; k < nums.Length; k++)
        // {
        //   Console.WriteLine("arr: " + nums[k]);
        // }
      }
      for (int j = count; j < nums.Length; j++) nums[j] = 0;
    }
    static void Main(string[] args)
    {
      MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
    }
  }
}
