using System;
using System.Collections.Generic;
using System.Linq;

namespace olymp
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            var input = Console.ReadLine().Split(" ");
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            List<int> rawData = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            List<int> count1 = new List<int>();
            List<int> count0 = new List<int>();


            for (int i = 0; i < m; i++)
            {
                count0.Add(0);
                count1.Add(0);
            }
            for (int i = 0; i < rawData.Count; i++)
            {
                if (rawData[i] == 1)
                    count1[i % m]++;
                else
                    count0[i % m]++;
            }
            int ans = 0;
            for (int i = 0; i < m; i++)
            {
                ans += Math.Min(count1[i], count0[i]);
            }
            Console.WriteLine(ans);
        }
    }
}
