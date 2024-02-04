/*
Задача 3: Напишите программу, 
которая принимает на вход целое число из отрезка [10, 99]
и показывает наибольшую цифру числа.
40 => 4
96 => 9
72 => 7
*/

int a = 79;
int firstDigit = a / 10;
int secondDigit = a % 10;

if (a >= 10 & a <=99)
{
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
else
{
    Console.WriteLine("недопустимое значение");
}


