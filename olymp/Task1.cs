using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Имеется неограниченно много обыкновенных костяшек домино размера 2×1.
 * Требуется поместить как можно большее число костяшек без наложений на клеточную доску размера M×N клеток так,
 * что каждая костяшка домино закрывает ровно две клетки доски (при этом переворачивание костяшек допускается).
 * Какое максимально возможное число костяшек можно поместить на доску таким образом?
 * 
 * Входные данные
 * В единственной строке записаны размеры доски: два целых числа M и N (при этом 1≤M≤N≤16
 * 
 * Выходные 
 * Необходимо вывести ровно одно целое число — максимальное количество костяшек, которые можно уложить.
 */

namespace olymp
{
    public static class Task1
    {
        public static void Run()
        {
            int n, m, ans;
            string input = Console.ReadLine();
            string[] a = input.Split(" ");
            n = int.Parse(a[0]);
            m = int.Parse(a[1]);
            ans = m / 2 * n;
            if (m % 2 != 0) ans += n / 2;
            Console.WriteLine(ans);
        }
    }
}
