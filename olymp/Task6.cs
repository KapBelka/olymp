﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olymp
{
    public static class Task6
    {
        public static void Run()
        {
            int k, l, m, n, d, ans = 0 ;
            k = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            for (int i = 1; i <= d; i++)
            {
                if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0) ans++;
            }
            Console.WriteLine(ans);
        }
    }
}
