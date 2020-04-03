using System;
using System.Linq;
namespace single_number
{
  class Program
  {
    public static int SingleNumber(int[] nums)
    {
      return nums.GroupBy(x => x).Single(y => y.Count() == 1).Key;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(SingleNumber(new int[] { 2, 2, 1 }));
      Console.WriteLine(SingleNumber(new int[] { 4, 1, 2, 1, 2 }));

    }
  }
}
