using System;

namespace palindrome_number
{
  class Program
  {
    public static bool IsPalindrome(int x)
    {
      if (x < 0) return false;
      if (x < 9) return true;
      if (x % 10 == 0 && x != 0) return false;

      int revertNum = 0;
      while (x > revertNum)
      {
        revertNum = revertNum * 10 + x % 10;
        x = x / 10;
      }
      return x == revertNum || x == revertNum / 10;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(IsPalindrome(121));
      Console.WriteLine(IsPalindrome(-121));
      Console.WriteLine(IsPalindrome(20));
    }
  }
}
