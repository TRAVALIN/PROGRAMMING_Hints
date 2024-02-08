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

int a = 12345;
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
    Console.Write(x1 % 10 + ", ");
    x1 = x1 / 10;
    i = i + 1;
}

if (i == countDigit - 1)
{
    Console.Write(x1 % 10);
}

/* Решение с прямым порядком цифр */

Console.WriteLine(" ");
Console.WriteLine(" ");

int pow = 10;
for (int j = 1; j < countDigit; j++)
{
    pow = pow * 10;
}

int ostatok = 0;
int delitel = 0;
int Digit = 0;
int k = 1;
while (k < pow / 10)
{
    ostatok = a % (pow / k);
    delitel = pow / (10 * k);
    Digit = ostatok / delitel;
    k = k * 10;
    Console.Write($"{Digit}, ", " ");
}
if (k == pow / 10)
{
    ostatok = a % (pow / k);
    delitel = pow / (10 * k);
    Digit = ostatok / delitel;
    k = k * 10;
    Console.Write(Digit);
}