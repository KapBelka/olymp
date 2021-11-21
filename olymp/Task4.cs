﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Перед Вами и Вашей командой поставлена задача написать модуль анализа показаний мульти-весов.
 * Мульти-весы позволяют взвешивать набор грузов с учетом правила рычага и представляют собой стержень,
 * лежащий на точке опоры, к которому могут быть привешены грузы. Ваша задача - определить,
 * находятся ли весы в балансе.
 *
 * На вход в модуль приходит строка, содержащая покоординатную информацию о весах.
 * Нулевой символ строки описывает состояние стержня мульти-весов в координате 0 на координатной прямой.
 * Первый символ описывает состояние в координате 1 и так далее. Всего возможно три типа символов:
 *
 * 1) Символ номер i может быть равен «^», что обозначает: точка опоры находится в координате i под стержнем.
 * 2) Символ номер i может быть равен «=», что обозначает: к стержню мульти-весов в точке с координатой i не привешено никакого груза.
 * 3) Символ номер i может быть равен цифре 1-9, что обозначает: к стержню мульти-весов привешен груз соответствующей массы в точке с координатой i.
 *
 * Отметим, что грузы могут быть привешены к стержню мульти-весов только в точках с целочисленными координатами.
 * Отметим также, что если на вход модуля пришла строка длиной n, то длина стержня мульти-весов составляет n−1,
 * и левая граница стержня находится в точке с координатой 0, а правая граница - в точке с координатой n−1.
 *
 * Ваш модуль в результате по описанию мульти-весов должен выдать, будут ли они находиться в состоянии равновесия.
 * Весом стержня можно пренебречь. Изначально стержень находится в равновесии, далее к нему одновременно привешивают все грузы.
 * После этого стержень, либо отклоняется влево, либо отклоняется вправо, либо будет находиться в состоянии баланса.
 * 
 * Входные данные
 * В первой строке задано описание мульти-весов — непустая строка s (3≤|s|≤106). Строка может состоять из цифр (1-9) и символов «^»
 * (встречается ровно 1 раз, при этом не является самым первым или самым последним символом входной строки) и «=».
 *
 * Выходные данные
 * В случае если левая часть стержня мульти-весов окажется ниже, необходимо выдать «left»,
 * если ниже окажется правая часть стержня мульти-весов, необходимо выдать «right»,
 * в случае равновесия стержня необходимо выдать «balance».
 */

namespace olymp
{
    public static class Task4
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Split("^");
            List<char> left = input[0].Reverse().ToList();
            List<char> right = input[1].ToList();
            long sumLeft = 0, sumRight = 0;

            for (int i = 0; i < left.Count; i++)
            {
                if (left[i] != '=')
                    sumLeft += int.Parse(left[i].ToString()) * (i + 1);
            }

            for (int i = 0; i < right.Count; i++)
            {
                if (right[i] != '=')
                    sumRight += int.Parse(right[i].ToString()) * (i + 1);
            }

            if (sumLeft == sumRight)
                Console.WriteLine("balance");
            else if (sumLeft > sumRight)
                Console.WriteLine("left");
            else
                Console.WriteLine("right");
        }
    }
}
