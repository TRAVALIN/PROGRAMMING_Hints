/*
Задайте двумерный массив. Найдите элементы, у которых оба
индекса чётные, и замените эти элементы на их квадраты.
Пример
2 3 4 3
4 3 4 1 =>
2 9 5 4

4 3 4 3
4 3 4 1
2 9 25 4
*/

int[,] matrix =
{
    { 2, 3, 4, 3 },
    { 4, 3, 4, 1 },
    { 2, 9, 5, 4 }
};

void ChangeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 & j % 2 == 0 & i == j)
            {
            matrix[i, j] *= matrix[i, j];
            }
        }
    }
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

PrintMatrix(matrix);
ChangeMatrix(matrix);
PrintMatrix(matrix);
