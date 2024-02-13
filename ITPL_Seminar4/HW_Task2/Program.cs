/*
Задача 2: Задайте массив заполненный случайными
трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в
массиве.
[344 452 341 125] => 2
*/

Console.Write("Введите количество элементов в массиве: ");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);

int[] array_of_user = CreateRandomArray(n);
ShowPrintArray(array_of_user);
//int[] array_of_user = { 444, 422, 424, 122 };
int count_evenDigit = CountEvenNumberFromArray(array_of_user);
ShowPrintCountEvenDigitFromArray(count_evenDigit);

// Блок с функциями (методами):

int[] CreateRandomArray(int size)
{
    size = n;
    int[] array = new int[n];
    var rnd = new Random(); // или Random random = new Random();//Генераторслучайныхчисел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000); // или random.Next(100, 1000)
    }
    return array;
}


void ShowPrintArray(int[] array)
{
    Console.Write("Сгенерирован массив из случайных трёхзначных чисел: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


int CountEvenNumberFromArray(int[] array)
{
    int count_evenDigit = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (array[i] % 2 == 0)
        {
            count_evenDigit++;
        }
    }
    return count_evenDigit;
}

void ShowPrintCountEvenDigitFromArray(int count_evenDigit)
{
    Console.Write($"Количество чётных элементов в массиве: {count_evenDigit}");
}

/* РЕЗУЛЬТАТ РАБОТЫ ПРОГРАММЫ ИЗ КОНСОЛИ:

Введите количество элементов в массиве: 12
Сгенерирован массив из случайных трёхзначных чисел: [ 389 548 484 437 188 218 790 420 902 531 317 246 ]
Количество чётных элементов в массиве: 8
*/


