/*
Задача 2: Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 3 -> A(m,n) = 61
m = 3, n = 5 -> A(m,n) = 253
*/

int m = 3;
int n = 5;
if (m >= 0 && n >= 0)
{
    Console.WriteLine(FunctionAckerman(m, n));
}
else
{
    Console.WriteLine("Значения m и n должны быть больше либо равны 0");
}

int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (n == 0 && m > 0)
    {
        return FunctionAckerman(m - 1, 1);
    }
    else
    {
        return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    }
}
