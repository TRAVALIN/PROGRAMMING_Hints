﻿/*
Задача 1: Задайте значения M и N. Напишите
программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не
использовать циклы.

M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8"

*/

int m = -5;
int n = 10;

CheckAndLaunchRangeNumbers(m, n);
void CheckAndLaunchRangeNumbers(int m, int n)
{
    if (n < m)
    {
        Console.Write("Переменная n должна быть больше или равна m!");
    }
    else
    {
        RangeNumbers(m, n);
    }
}

void RangeNumbers(int m, int n)
{
    if (n >= m)
    {
        if (m - 1 == n)
        {
            return;
        }
        Console.Write(m);
        if (m < n)
        {
            Console.Write(", ");
        }
        RangeNumbers(m + 1, n);
    }
}
