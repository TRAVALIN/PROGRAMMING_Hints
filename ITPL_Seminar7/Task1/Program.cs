/*
Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
Указание
Использовать рекурсию.
Пример
123 => 6
63 => 9

*/

int SumDigits(int number)
{
    if (number == 0)
    {
        return 0;
    }
    return number % 10 + SumDigits(number / 10);
}

int number = 1234;
int sum = SumDigits(number);
Console.WriteLine(sum);