using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPCoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] coins_temp = Console.ReadLine().Split(' ');
            int[] coins = Array.ConvertAll(coins_temp, Int32.Parse);
            ChangeAmount(n, coins, m);
        }
        public static void ChangeAmount(int amount, int[] coins, int len)
        {
            long[] array = new long[amount + 1];
            array[0] = 1;
            for (int j = 0; j < len; j++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (i >= coins[j])
                    {
                        array[i] += array[i - coins[j]];
                    }
                }
            }
            Console.WriteLine(array[amount]);
            Console.ReadLine();
        }
    }
}
