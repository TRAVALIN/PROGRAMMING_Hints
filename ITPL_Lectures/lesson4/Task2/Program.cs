/*
проверка чисел массива на интересность = сумма цифр числа чётная
*/

int[,] CreateMatrix(int rowsCount, int columnsCount)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

int rowsCount = 2;
int columnsCount = 3;
int[,] matrix = CreateMatrix(rowsCount, columnsCount);

foreach (var e in matrix)
{
    if (IsIntresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsIntresting(int value)
{
    int sumDigits = GetSumDigits(value);
    if (sumDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintMatrix(matrix);