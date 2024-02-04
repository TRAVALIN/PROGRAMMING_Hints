/*
Задача 4: Напишите программу, 
которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.

Решить с обратным порядком цифр, в эталонном решении такой вариант.

568 => 5,6,8
8 => 8
9542 => 9,5,4,2
*/

/* РЕШЕНИЕ с ОБРАТНЫМ ПОРЯДКОМ ЦИФР: */
using System.Globalization;

int a = 154;
int x = a;
int countDigit = 0;

while (x != 0)
{
   x = x / 10;
   countDigit++;
}

int i = 0;
int x1 = a;
while (i < countDigit - 1)
{
    Console.Write(x1 % 10+ ", ");
    x1 = x1 / 10;
    i = i + 1;
}

if (i == countDigit -1)
{
    Console.Write(x1 % 10);
}