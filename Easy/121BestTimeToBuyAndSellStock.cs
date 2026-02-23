using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _121BestTimeToBuyAndSellStock
    {
        public static void Display()
        {
            Console.WriteLine(MaxProfit(new int[] {7, 1, 5, 3, 6, 4}));
            Console.WriteLine(MaxProfit(new int[] {7, 6, 4, 3, 1}));
        }

        private static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length <= 1)
                return 0;

            int min = prices[0];
            int profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (min > prices[i])
                    min = prices[i];
                else if (profit < prices[i] - min)
                    profit = prices[i] - min;
            }

            return profit;
        }
    }
}
