using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olymp
{
    public static class Task5
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).OrderByDescending(x => x).ToList();
            List<int> ans = new List<int>();
            int countWorks = 0;
            int i = 1;
            ans.Add(list[0]);
            while (ans.Count != list.Count)
            {
                if (i + 1 < list.Count)
                {
                    ans.Add(list[i + 1]);
                    countWorks++;
                }
                if (i < list.Count)
                    ans.Add(list[i]);
                i += 2;
            }
            Console.WriteLine(countWorks);
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}
