void printSquares(int n)
{
    int i = 1;
    while (i <= n)
    {
        Console.Write($"{i*i} ");
        i = i + 1;
    }
}
printSquares(5);
Console.WriteLine();
printSquares(10);
Console.WriteLine();
printSquares(15);
Console.WriteLine();

int Bar (int a)
{
    a = 0;
    return a;
}

int value = Bar(5);
Console.WriteLine(value); // выводится 0 как и задумавалось

int res = 5;
Bar(res);
Console.WriteLine(res); /* вывод = 5 = нельзя изменить переменную
функции. Переменный a и res хранятся в разных ячейках памяти.

