/*
Задайте двумерный массив из целых чисел. Сформируйте новый
одномерный массив, состоящий из средних арифметических
значений по строкам двумерного массива.
Пример
2 3 4 3
4 3 4 1 => [3 3 5]
2 9 5 4
*/

// int[,] matrix =
// {
//     { 2, 3, 4, 3 },
//     { 4, 3, 4, 1 },
//     { 2, 9, 5, 4 }
// };



double[] ChangeMatrixinArrayFromMeansRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double currentMean = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            currentMean += matrix[i, j];
        }
        currentMean /= matrix.GetLength(1);
        array[i] = currentMean;
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    foreach (var item in array)
    {
        Console.Write($"{item:f1} ");
    }
    Console.Write("]");
}

int[,] matrix =
{
    { 1, 2, 3 },
    { 5, 2, 1 }
};

PrintMatrix(matrix);
double[] array = ChangeMatrixinArrayFromMeansRows(matrix);
PrintArray(array);


