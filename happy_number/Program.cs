using System;

namespace happy_number
{
  class Program
  {
    public static bool IsHappy(int n)
    {
      if (n == 1 || n == 7) return true;
      int sum = n, x = n;

      while (sum > 9)
      {
        sum = 0;
        while (x > 0)
        {
          int d = x % 10;
          sum += d * d;
          x /= 10;
          Console.WriteLine("d: " + d + ". sum: " + sum + ". x: " + x);
        }
        Console.WriteLine("sum final: " + sum);
        if (sum == 1) return true;
        x = sum;
      }
      if (sum == 7) return true;
      return false;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(IsHappy(13));
      Console.WriteLine(IsHappy(15));
    }
  }
}
