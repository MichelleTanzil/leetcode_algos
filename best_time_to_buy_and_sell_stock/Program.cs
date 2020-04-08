using System;

namespace best_time_to_buy_and_sell_stock
{
  class Program
  {
    public static int MaxProfit(int[] prices)
    {
      int maxProfit = 0;
      for (int i = 1; i < prices.Length; i++)
      {
        if (prices[i] - prices[i - 1] > 0)
        {
          maxProfit += prices[i] - prices[i - 1];
        }
      }
      return maxProfit;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 }));
      Console.WriteLine(MaxProfit(new int[] {1, 2, 3, 4, 5 }));
      Console.WriteLine(MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
    }
  }
}
