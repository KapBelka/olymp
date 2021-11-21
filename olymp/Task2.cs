using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * На доске в ряд записано n различных чисел. Петя выбирает большее из двух крайних чисел
 * (крайнее левое или крайнее правое число в ряду), стирает это число с доски и берет себе из вазочки количество конфет,
 * равное выбранному числу. На доске остается n−1 число, и теперь уже Витя выбирает большее из двух крайних чисел,
 * стирает его и набирает себе конфеты. Дальше снова выбирает Петя и т.д.
 *
 * Определите, у кого сколько будет конфет, когда все числа окажутся стерты.
 *
 * Входные данные
 * В первой строке записано количество чисел на доске: целое число n (1≤n≤1000). Во второй строке перечислены записанные на доске числа через пробел (различные целые числа от 1 до 1000).
 *
 * Выходные данные
 * Необходимо вывести через пробел два целых числа — количество конфет у Пети и у Вити соответственно.
 */

namespace olymp
{
    public static class Task2
    {
        public static void Run()
        {
            int n, sum1 = 0, sum2 = 0;
            bool isFirstPlayer = true;
            n = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            while (list.Count > 0)
            {
                if (list[0] > list[list.Count - 1])
                {
                    if (isFirstPlayer)
                        sum1 += list[0];
                    else
                        sum2 += list[0];
                    isFirstPlayer = !isFirstPlayer;
                    list.RemoveAt(0);
                }
                else
                {
                    if (isFirstPlayer)
                        sum1 += list[list.Count - 1];
                    else
                        sum2 += list[list.Count - 1];
                    isFirstPlayer = !isFirstPlayer;
                    list.RemoveAt(list.Count - 1);
                }
            }
            Console.WriteLine(sum1 + " " + sum2);
        }
    }
}
