using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOnCSharp._27_03_2023
{
    internal class Buy_Sell
    {

        public void FindMaxProfit()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            int left = 0, right = 1;
            int max_profit = 0;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                {
                    int current_profit = prices[right] - prices[left];
                    max_profit = Math.Max(max_profit, current_profit);
                }
                else
                {
                    left = right;
                }

                right++;
            }

            Console.WriteLine("The Max Profit is : "+ max_profit);


        }
    }
}
