﻿/*
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
N=5 => 1 2 3 4 5

*/

void RangeDigits(int n, int m = 1)
{
    if (m == n)
    {
        Console.WriteLine(m);
        return;
    }
    Console.Write(m + " ");
    RangeDigits(n, m + 1);
}

int n = 8;
RangeDigits(n);
