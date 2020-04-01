using System;

namespace reverse_integer
{
  class Program
  {
    public static int Reverse(int x)
    {
      string xString = x.ToString();
      string result = "";
      if (x < 0)
      {
        result += "-";
        for (int i = xString.Length - 1; i > 0; i--) result += xString[i];
      }
      else
      {
        for (int i = xString.Length - 1; i >= 0; i--) result += xString[i];
      }
      long output = Convert.ToInt64(result);
      if (output > int.MaxValue || output < int.MinValue) return 0;
      return (int)output;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(Reverse(123));
      Console.WriteLine(Reverse(-123));
      Console.WriteLine(Reverse(120));
    }
  }
}
