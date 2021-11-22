using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * В одной студенческой группе учится d студентов. Это очень умные и активные студенты, многие из них участвуют в студенческих олимпиадах и конкурсах.
 *
 * В конце семестра открыли список группы, и оказалось, что каждый k-й студент в списке участвовал в олимпиаде по программированию.
 * Каждый l-й решал задачи на олимпиаде по математике. Каждый m-й участвовал в конкурсе поэтов и чтецов. А каждый n-й не спал ночами на хакатоне.
 *
 * Сколько всего студентов группы участвовало в олимпиадах, конкурсах, хакатонах?
 *
 * Входные данные
 * На каждой из четырех входных строк содержатся целые числа k,l,m,n и d, каждое число в отдельной строке (1≤k,l,m,n≤10, 1≤d≤105).
 * 
 * Выходные данные
 * Выведите число студентов - участников соревнований.
 */

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
