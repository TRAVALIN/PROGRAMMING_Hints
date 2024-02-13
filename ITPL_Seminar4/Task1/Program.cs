/*
Задание 1. Совместная работа
Семинар 4. Функции
20 мин
Задайте одномерный массив, заполненный случайными
числами. Определите количество простых чисел в этом
массиве.
Примеры
[1 3 4 19 4] => 2
[4 3 4 1 9 5 21 13] => 3
*/

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     var rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(minValue, maxValue+1);
//     }
//     return array;
// }


bool IsPrime(int number)
{
    if (number == 1)
    {
        return false;
    }
    
    for (int i = 2; i < number; i++)
    {
       if (number % i == 0)
       {
        return false;
       }
    }
    return true;
}

int CountIsPrimeNumber(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (IsPrime(array[i]))
    {
        count++;
    }
    return count;
}

void ShowPrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

// int[] array = CreateRandomArray(10, 1, 100);

int[] array = { 4, 3, 4, 1, 9, 5, 21, 13, 2 };
ShowPrintArray(array);
CountIsPrimeNumber(array);
Console.WriteLine(CountIsPrimeNumber(array));


// for (int i = 2; i < 11; i++)
// {
//     Console.WriteLine($"{i} {IsPrime(i)}");
// }