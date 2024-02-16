/*
Задача 3: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с
наименьшей суммой элементов.
4 3 1 => строка с индексом 0, сумма = 8 !!! выводится только 0
2 6 9
4 6 2
*/

int[,] number = new int[,] {
    {1, 2, 3},
    {1, 1, 10},
    {7, 8, 2},
    {0, 1, 2}
};

int[] SumRows(int[,] number)
{
    int[] array = new int[number.GetLength(0)];
    for (int i = 0; i < number.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < number.GetLength(1); j++)
        {
            sum += number[i, j];
        }
        array[i] = sum;
    }
    return array;

}

int MinIndex(int[] array)
{
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[minIndex] > array[i])
        {
            minIndex = i;
        }
    }
    return minIndex;

}

void PrintReault(int minIndex)
{
    Console.Write(minIndex);
}


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     foreach (var item in array)
//     {
//         Console.Write($"{item} ");
//     }
//     Console.Write("]");
// }



int[] array = SumRows(number);
// PrintArray(array);
int minIndex = MinIndex(array);
PrintReault(minIndex);
