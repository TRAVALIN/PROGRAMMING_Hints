/*
Задача 2: Задайте двумерный массив. Напишите
программу, которая поменяет местами первую и
последнюю строку массива.
4 3 1 => 4 6 2
2 6 9    2 6 9
4 6 2    4 3 1
*/

int[,] numbers = new int[,]
{
    { 1, 2, 3, 4 },
    { 5, 6, 7, 8 },
    { 9, 10, 11, 12 }
};

// РЕШЕНИЕ ТРАВАЛИНа:

Console.Write("Решение ТРАВАЛИН\n");
int[,] array = new int[numbers.GetLength(0), numbers.GetLength(1)];

for (int i = 0; i < array.GetLength(0); i++)
{
    if (i == 0)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = numbers[numbers.GetLength(0) - 1, j];
            Console.Write($"{array[i, j]}\t");
        }
        Console.Write("\n");
    }

    if (i != 0 & i < array.GetLength(0) - 1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.Write("\n");
    }

    if (i == array.GetLength(0) - 1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = numbers[0, j];
            Console.Write($"{array[i, j]}\t");
        }
    }
}
Console.WriteLine("\n");

/* !!!!! ОПТИМАЛЬНОЕ РЕШЕНИЕ от GeekBrains !!!!! */

Console.Write("!!!!! ОПТИМАЛЬНОЕ РЕШЕНИЕ от GeekBrains !!!!!\n");

// Печать массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
int[,] SwapFirstLastRows(int[,] array)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        SwapItems(array, column);
    }
    return array;
}

// Обмен элементами массива
void SwapItems(int[,] array, int column)
{
    int temp = array[0, column];
    array[0, column] = array[array.GetLength(0) - 1, column];
    array[array.GetLength(0) - 1, column] = temp;
}

PrintArray(SwapFirstLastRows(numbers));

/* и ещё даже вот так можно решить эту задачу */
Console.WriteLine(" ");
Console.Write("И даже так можно решить эту задачу\n");
Console.Write("9\t10\t11\t12\t\n" + "5\t6\t7\t8\t\n" + "1\t2\t3\t4");

//Console.WriteLine(number.GetLength(0));
///Console.WriteLine(number.GetLength(1));
//Console.Write($"{array[i, j]}\t");
//Console.WriteLine($"{number.GetLength(0) - 1}\t");
