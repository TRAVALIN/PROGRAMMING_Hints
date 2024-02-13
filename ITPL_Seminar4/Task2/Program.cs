/*
Задание 2. Обсуждение решений
Семинар 4. Функции
Задайте массив из N случайных целых чисел (N вводится с
клавиатуры).
Найдите количество чисел, которые оканчиваются на 1 и
делятся нацело на 7.
Пример
[1 5 11 21 81 4 0 91 2 3]
=> 2
*/

Console.WriteLine("Введите количество элементов n в массиве:");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);


int[] CreateRandomArray(int size)
{
    size = n;
    int[] array = new int[n];
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 22);
    }
    return array;
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

int[] array = CreateRandomArray(n);
ShowPrintArray(array);

Console.WriteLine(" ");
int countDigitFinish1 = 0;
int countDigitmultiple7 = 0;
foreach (var item in array)
{
    if (item % 10 == 1)
    {
        Console.Write(item % 10);
        Console.Write(" ");
        countDigitFinish1++;
    }
}
foreach (var item in array)
{
    if (item % 7 == 0)
    {
        Console.Write("[");
        Console.Write(item % 7);
        Console.Write("] ");
        countDigitmultiple7++;
    }
}


Console.WriteLine(" ");
Console.WriteLine($"{countDigitFinish1} заканчиваются на 1");
Console.WriteLine($"{countDigitFinish1} делятся на 7 без остатка");